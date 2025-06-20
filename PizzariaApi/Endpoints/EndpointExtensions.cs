

namespace Pizzaria.Endpoints;

public static class EndpointExtensions {
    
    public static void MapEndpointExtensions (this WebApplication app) {

        app.MapClienteEndpoints();
        app.MapPizzaEndpoints();
        app.MapSobremesaEndpoints();
        app.MapBebidaEndpoints();
        app.MapFilialEndpoints();
    }
}