//Minimal APIs em C#
//Testar a API
// - RestClient - Extensão VS Code
// - Postman
// -Insomnia
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//Endpoints - Funcionalidades
//Requisição - URL e Método/Verbo HTTP  
app.MapGet("/", () => "Hello world em C# !");

app.MapGet("/", () => "Segunda Funiconalidade");

app.Run();
//exercicio para próxima aula
//Criar um endpoint para receber informação pela url
