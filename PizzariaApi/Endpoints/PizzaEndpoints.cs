using System.Text.Json;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Data;
using Pizzaria.Models;

namespace Pizzaria.Endpoints;

public static class PizzaEndpoints {

    public static void MapPizzaEndpoints(this WebApplication app) {
        //Todas pizzas
        app.MapGet("pizzas/", (AppDbContext a) => {
            var pizzas = a.Tb_pizza.ToList();
            return Results.Ok(pizzas);
        });

        //Nova pizza
        app.MapPut("/newPizza", () => {
        
        });
    }
}