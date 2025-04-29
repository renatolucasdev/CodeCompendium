// Configura��o Builder
using PorBaixoDosPanos;
//Classe que possui a responsabilidade de construir uma inst�ncia de aplica��o AS.NET com todas as configura��es definidas
var builder = WebApplication.CreateBuilder(args);
//Configura��o do Pipeline
builder.AddSerilog();//Adiciona o Serilog como logger padr�o da aplica��o via extension method
//Adiciona o MVC ao pipeline da aplica��o. Tamb�m � um extension method
//builder.Services.AddControllersWithViews();//Navegando nos m�todos, chega-se at� o C# puro.
//Middlewares
//Services

//Configura��o da App
//Inst�ncia que representa a aplica��o e todas as configura��es dos middlewares e seus comportamentos durante um request
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
