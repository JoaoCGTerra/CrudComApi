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

app.MapPost("/newCliente", async (HttpContext context ,IValidator<Tb_cliente> validator, Tb_cliente cliente, AppDbContext a) => {
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



app.Run();
