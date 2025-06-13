var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.ListenAnyIP(3000);
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
