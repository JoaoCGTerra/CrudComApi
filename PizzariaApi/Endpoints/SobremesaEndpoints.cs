using System.Text.Json;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Data;
using Pizzaria.Models;

namespace Pizzaria.Endpoints;

public static class SobremesaEndpoints {

    public static void MapSobremesaEndpoints(this WebApplication app) {
        //Todas sobremesas
        app.MapGet("sobremesas/", (AppDbContext a) => {
            var sobremesas = a.Tb_sobremesa.ToList();
            return Results.Ok(sobremesas);
        });
    }
}