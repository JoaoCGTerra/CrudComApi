using System.Text.Json;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Data;
using Pizzaria.Models;

namespace Pizzaria.Endpoints;

public static class FilialEndpoints {
    
    public static void MapFilialEndpoints (this WebApplication app){
        //Todas as filiais
        app.MapGet("/filiais/", (AppDbContext a) => {
            var filiais = a.Tb_filiais.ToList();
            return Results.Ok(filiais);
        });
        //Busca por filial especifica
        app.MapGet("/filial/{idRecebido}", async (HttpContext context, [FromServices] AppDbContext a) => {

            var idRecebido = context.Request.RouteValues["idRecebido"];

            if (!int.TryParse((string?)idRecebido, out int id)) {
                return Results.BadRequest("Valor na rota não é um ID valido");
            }

            var filialEncontrada = await a.Tb_filiais.FindAsync(id);

            if(filialEncontrada == null) {
                return Results.NotFound($"Filial {id} não encontrada");
            }

            return Results.Ok(filialEncontrada);
        });

        //Nova filial
        app.MapPost("/newFilial", async ([FromBody]Tb_filiais filial, [FromServices] IValidator<Tb_filiais> validator,[FromServices] AppDbContext a) => {

            var validacaoFilial = await validator.ValidateAsync(filial);

            if (!validacaoFilial.IsValid) {
                return Results.BadRequest(validacaoFilial.Errors.Select(e => e.ErrorMessage));
            }

            try {
                a.Tb_filiais.Add(filial);
                await a.SaveChangesAsync();

                return Results.Created($"/filial/{filial.Id}", filial);
            }
            catch (Exception e) {
                return Results.BadRequest($"Erro ao inserir no banco de dados\n{e}");
            }
        });

        //Modificar filial
        app.MapPut("/modFilial/{idRecebido}", async (HttpContext context, [FromBody] Tb_filiais filial,[FromServices]AppDbContext a) => {

            var idRecebido = context.Request.RouteValues["idRecebido"];

            if (!int.TryParse((string?)idRecebido, out int id)) {
                return Results.BadRequest("Valor na rota não é um ID valido");
            }

            var filialEncontrada = await a.Tb_filiais.FindAsync(id);

            if(filialEncontrada == null) {
                return Results.NotFound($"Filial {id} não encontrada");
            }
            
            if (filial.Nome_filial != null) {
                filialEncontrada.Nome_filial = filial.Nome_filial;
            }
            if (filial.Endereco_Filial != null) {
                filialEncontrada.Endereco_Filial = filial.Endereco_Filial;
            }
            if (filial.Telefone_Filial != null) {
                filialEncontrada.Telefone_Filial = filial.Telefone_Filial;
            }
            if (filial.Descricao_filial != null) {
                filialEncontrada.Descricao_filial = filial.Descricao_filial;
            }
            try {
                a.Tb_filiais.Update(filialEncontrada);

                await a.SaveChangesAsync();
                return Results.Ok("Filial alterada");
            }
            catch (Exception e) {
                return Results.BadRequest($"Erro ao atualizar no banco de dados\n{e}");
            }
        });

        //Deletar 1 filial
        app.MapDelete("/delFilial/{idRecebido}", async (HttpContext context, [FromServices] AppDbContext a) => {
            var idRecebido = context.Request.RouteValues["idRecebido"];

            if(!int.TryParse((string?)idRecebido, out int id)) {
                return Results.BadRequest("Valor na rota não é um ID valido");
            }

            var filialEncontrada = await a.Tb_filiais.FindAsync(id);
            if(filialEncontrada == null) {
                return Results.NotFound($"Filial {id} não encontrada");
            }

            try {
                a.Tb_filiais.Remove(filialEncontrada);
                await a.SaveChangesAsync();
                return Results.Ok("Filial removida do banco de dados");
            }
            catch(Exception e) {
                return Results.BadRequest($"Erro ao remover do banco de dados\n{e}");
            }

        });
    }
}