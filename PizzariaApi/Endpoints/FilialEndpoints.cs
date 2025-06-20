using System.Text.Json;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Data;
using Pizzaria.Models;

namespace Pizzaria.Endpoints;

public static class FilialEndpoints {
    
    public static void MapFilialEndpoints (this WebApplication app){
        app.MapGet("filiais/", (AppDbContext a) => {
            var filiais = a.Tb_filiais.ToList();
            return Results.Ok(filiais);
        });
    }
}