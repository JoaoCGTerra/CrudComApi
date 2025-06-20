using System.Text.Json;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Data;
using Pizzaria.Models;

namespace Pizzaria.Endpoints;

public static class BebidaEndpoints {

    public static void MapBebidaEndpoints(this WebApplication app) {
        //Todas bebidas
        app.MapGet("bebidas/", (AppDbContext a) => {
            var bebidas = a.Tb_bebida.ToList();
            return Results.Ok(bebidas);
        });
    }
}