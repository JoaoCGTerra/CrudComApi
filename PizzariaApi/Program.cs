using System.Text.Json;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pizzaria.Data;
using Pizzaria.Models;
using Pizzaria.Validators;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<ValidatorCliente>());
builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.ListenAnyIP(3000);
});

var app = builder.Build();

app.MapGet("/clientes", (AppDbContext a) => {
    var clientes = a.Tb_cliente.ToList(); 
    return Results.Ok(clientes);
});
app.MapGet("filiais/", (AppDbContext a) => {
    var filiais = a.Tb_filiais.ToList();
    return Results.Ok(filiais);
});
app.MapGet("pizzas/", (AppDbContext a) => {
    var pizzas = a.Tb_pizza.ToList();
    return Results.Ok(pizzas);
});
app.MapGet("sobremesas/", (AppDbContext a) => {
    var sobremesas = a.Tb_sobremesa.ToList();
    return Results.Ok(sobremesas);
});
app.MapGet("bebidas/", (AppDbContext a) => {
    var bebidas = a.Tb_bebida.ToList();
    return Results.Ok(bebidas);
});
//Acha cliente por id
app.MapGet("/cliente/{id}", async (HttpContext context, [FromServices] AppDbContext a) => {

    var recebido = context.Request.RouteValues["id"];

    if (!int.TryParse((string?)recebido, out int id)) {
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


app.MapPost("/newCliente", async ([FromServices]IValidator<Tb_cliente> validator, [FromBody]Tb_cliente cliente, [FromServices]AppDbContext a) => {
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

app.MapPut("/modCliente/{id}", async ([FromRoute] int id, [FromBody]Tb_cliente cliente, [FromServices] AppDbContext a) =>{

    var clienteEncontrado = a.Tb_cliente.FirstOrDefault(x => x.Id == id);
    if(clienteEncontrado == null) {
        return Results.NotFound();
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
    }catch(Exception e) {
        return Results.BadRequest($"Erro ao atualizar no banco: {e}");
    }

});

app.MapDelete("/delCliente/{id}", ([FromRoute] int id, [FromServices] AppDbContext a)=>{

    var clienteBuscado = a.Tb_cliente.FirstOrDefault(x => x.Id == id);
    try {
        a.Tb_cliente.ExecuteDelete();
        return Results.Ok();
    }catch(Exception e) {
        return Results.BadRequest($"Erro ao excluid cliente: {e}");
    }
});




app.Run();
