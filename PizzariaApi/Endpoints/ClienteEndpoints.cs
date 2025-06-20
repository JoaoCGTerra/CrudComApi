using System.Text.Json;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Data;
using Pizzaria.Models;

namespace Pizzaria.Endpoints;
public static class ClienteEndpoints {

    public static void MapClienteEndpoints (this WebApplication app) {
        
        //Todos clientes
        app.MapGet("/clientes", (AppDbContext a) => {
            var clientes = a.Tb_cliente.ToList();
            return Results.Ok(clientes);
        });

        //Cliente por id
        app.MapGet("/cliente/{id}", async (HttpContext context, [FromServices] AppDbContext a) => {

            var IdRecebido = context.Request.RouteValues["id"];

            if (!int.TryParse((string?)IdRecebido, out int id)) {
                return Results.BadRequest("Valor na rota não é um INT");
            }

            try {
                var busca = await a.Tb_cliente.FindAsync(id);
                if (busca == null) {
                    return Results.NotFound($"Cliente {id} não encontrado");
                }
                return Results.Ok(busca);
            }
            catch (Exception e) {
                return Results.BadRequest($"Erro na consulta\n{e}");
            }
        });

        //Novo cliente
        app.MapPost("/newCliente", async ([FromServices] IValidator<Tb_cliente> validator, [FromBody] Tb_cliente cliente, [FromServices] AppDbContext a) => {
            try {
                var validacaoUsuario = await validator.ValidateAsync(cliente);

                if (!validacaoUsuario.IsValid) {
                    return Results.BadRequest(validacaoUsuario.Errors.Select(e => e.ErrorMessage));
                }

                a.Tb_cliente.Add(cliente);
                await a.SaveChangesAsync();

                return Results.Created($"/cliente/{cliente.Id}", cliente);
            }
            catch (JsonException) {
                return Results.BadRequest("Erro no JSON");
            }
        });

        //Modificar cliente
        app.MapPut("/modCliente/{id}", async ([FromRoute] int id, [FromBody] Tb_cliente cliente, [FromServices] AppDbContext a) => {

            var clienteEncontrado = a.Tb_cliente.FirstOrDefault(x => x.Id == id);
            if (clienteEncontrado == null) {
                return Results.NotFound($"Cliente {id} não encontrado.");
            }
            try {
                clienteEncontrado.Nome_cliente = cliente.Nome_cliente;
                clienteEncontrado.Email_cliente = cliente.Email_cliente;
                clienteEncontrado.Rua_cliente = cliente.Rua_cliente;
                clienteEncontrado.Numero_rua_cliente = cliente.Numero_rua_cliente;
                clienteEncontrado.Cidade_cliente = cliente.Cidade_cliente;
                clienteEncontrado.Estado_cliente = cliente.Estado_cliente;
                clienteEncontrado.Cep_cliente = cliente.Cep_cliente;
                clienteEncontrado.Hash_senha_cliente = cliente.Hash_senha_cliente;
                clienteEncontrado.Is_admin = cliente.Is_admin;

                a.Tb_cliente.Update(clienteEncontrado);

                await a.SaveChangesAsync();

                return Results.Ok("Cliente alterado");
            }
            catch (Exception e) {
                return Results.BadRequest($"Erro ao atualizar no banco: {e}");
            }
        });

        //Deletar 1 cliente
        app.MapDelete("/delCliente/{id}", async (HttpContext context, [FromServices] AppDbContext a) => {

            var IdRecebido = context.Request.RouteValues["id"];

            if (!int.TryParse((string?)IdRecebido, out int id)) {
                return Results.BadRequest("Valor na rota não é um INT");
            }

            var clienteBuscado = a.Tb_cliente.FirstOrDefault(x => x.Id == id);
            if (clienteBuscado == null) {
                return Results.BadRequest("Cliente não encontrado");
            }   
            try {
                a.Tb_cliente.Remove(clienteBuscado);
                await a.SaveChangesAsync();
                return Results.Ok("Cliente excluído do banco de dados");

            }
            catch (Exception e) {
                return Results.BadRequest($"Erro ao excluir cliente: {e}");
            }
        });
    }

}