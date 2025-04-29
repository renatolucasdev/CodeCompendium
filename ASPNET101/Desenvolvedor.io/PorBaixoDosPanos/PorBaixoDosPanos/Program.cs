// Configuração Builder
using PorBaixoDosPanos;
//Classe que possui a responsabilidade de construir uma instância de aplicação AS.NET com todas as configurações definidas
var builder = WebApplication.CreateBuilder(args);
//Configuração do Pipeline
builder.AddSerilog();//Adiciona o Serilog como logger padrão da aplicação via extension method
//Adiciona o MVC ao pipeline da aplicação. Também é um extension method
//builder.Services.AddControllersWithViews();//Navegando nos métodos, chega-se até o C# puro.
//Middlewares
//Services

//Configuração da App
//Instância que representa a aplicação e todas as configurações dos middlewares e seus comportamentos durante um request
var app = builder.Build();
//app.UseMiddleware<LogTempoMiddleware>();//adiciona o middleware ao pipeline "natural" do ASP.NET Core
app.UseLogTempo();//adiciona o middleware ao pipeline "natural" do ASP.NET Core utilizando o extension method
app.MapGet("/", () => "Hello World!");
app.MapGet("/teste", () =>
{
    Thread.Sleep(1500);
    return "Teste 2";
});

app.Run();
