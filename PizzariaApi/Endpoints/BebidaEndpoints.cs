using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pizzaria.Data;
using Pizzaria.Models;

namespace Pizzaria.Endpoints;

public static class BebidaEndpoints {

    public static void MapBebidaEndpoints(this WebApplication app) {

        //Todas as bebidas
        app.MapGet("/bebidas", ([FromServices]AppDbContext a) => {
            var bebidas = a.Tb_bebida.ToList();
            return Results.Ok(bebidas);
        });

        //Bebida especifica
        app.MapGet("/bebida/{idRecebido}", async(HttpContext context, AppDbContext a) => {

            var idRecebido = context.Request.RouteValues["idRecebido"];
            if (!int.TryParse((string?)idRecebido, out int id)) {
                return Results.BadRequest("Valor na rota não é um ID valido");
            }

            try {
                var bebidaEncontrada = await a.Tb_bebida.FirstOrDefaultAsync(x => x.Id == id);
                if (bebidaEncontrada == null) {
                    return Results.NotFound($"Bebida {id} não encontrada");
                }
                
                return Results.Ok(bebidaEncontrada);

            }catch (Exception e) {
                return Results.BadRequest($"Erro ao procurar no banco de dados{e}");
            }
        });

        //Nova bebida
        app.MapPost("/newBebida", async ([FromServices] IValidator<Tb_bebida> validator, [FromBody] Tb_bebida bebida, [FromServices] AppDbContext a) => {
            
            var validacaoBebida = await validator.ValidateAsync(bebida);

            if (!validacaoBebida.IsValid) {
                return Results.BadRequest(validacaoBebida.Errors.Select(e => e.ErrorMessage));
            }
            try {
                await a.Tb_bebida.AddAsync(bebida);
                await a.SaveChangesAsync();
                return Results.Created($"/bebida/{bebida.Id}", bebida);
            }catch (Exception e) {
                return Results.BadRequest($"Erro ao inserir no banco de dados\n{e}");
            }
        });

        //Modificar bebida
        app.MapPut("/modBebida/{idRecebido}", async (HttpContext context, [FromBody] Tb_bebida bebida, [FromServices] AppDbContext a) => {

            var idRecebido = context.Request.RouteValues["idRecebido"];

            if(!int.TryParse((string?)idRecebido, out int id)) {
                return Results.BadRequest("Valor na rota não é um ID valido");
            }

            var bebidaEncontrada = a.Tb_bebida.FirstOrDefault(x => x.Id == id);
            if(bebidaEncontrada == null) {
                return Results.NotFound($"Bebida {id} não encontrada");
            }

            if (bebida.Nome_bebida != null) {
                bebidaEncontrada.Nome_bebida = bebida.Nome_bebida;
            }
            if (bebida.Valor_bebida != null) {
                bebidaEncontrada.Valor_bebida = bebida.Valor_bebida;
            }
            if (bebida.Descricao_bebida != null) {
                bebidaEncontrada.Descricao_bebida = bebida.Descricao_bebida;
            }
            if (bebida.Is_alcoolica != null) {
                bebidaEncontrada.Is_alcoolica = bebida.Is_alcoolica;
            }
            try {
                a.Tb_bebida.Update(bebidaEncontrada);
                await a.SaveChangesAsync();

                return Results.Ok("Bebida alterada no banco de dados");
            }catch (Exception e) {
                return Results.BadRequest($"Erro no bando de dados {e}");
            }
        });

        //Remover 1 bebida
        app.MapDelete("/delBebida/{idRecebido}", async (HttpContext context, [FromServices] AppDbContext a) => {

            var idRecebido = context.Request.RouteValues["idRecebido"];

            if (!int.TryParse((string?)idRecebido ,out int id)) {
                return Results.BadRequest("Valor na rota não é um ID valido");
            }

            try {
                var bebidaEncontrada = await a.Tb_bebida.FindAsync(id);
                if (bebidaEncontrada == null) {
                    return Results.NotFound($"Bebida {id} não encontrada");
                }

                a.Tb_bebida.Remove(bebidaEncontrada);
                await a.SaveChangesAsync();

                return Results.Ok("Bebida removida do banco de dados");
            }catch (Exception e) {
                return Results.BadRequest($"Erro ao remover do bando de dados\n {e}");
            }
        });
    }
}