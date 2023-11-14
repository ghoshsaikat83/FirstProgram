var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "My first .net Core Programe in VSCode!");

app.Run();