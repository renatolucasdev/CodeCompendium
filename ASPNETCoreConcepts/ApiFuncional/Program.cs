using ApiFuncional.Configuration;

var builder = WebApplication.CreateBuilder(args);

//Extension methods criados para configurar os servi�os nas classes Config
builder
    .AddApiConfig() 
    .AddCorsConfig()
    .AddSwaggerConfig()
    .AddDbContextConfig()
    .AddIdentityConfig();

var app = builder.Build();

if (app.Environment.IsDevelopment()) // Define configura��es espec�ficas para o ambiente de desenvolvimento
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("Development");
}
else // Define configura��es espec�ficas para o ambiente de produ��o
{
    app.UseCors("Production");
}

app.UseHttpsRedirection(); // Adiciona o middleware para redirecionar requisi��es HTTP para HTTPS
// N�o se pode inverter a order dos middlewares de autentica��o e autoriza��o
app.UseAuthentication(); // Adiciona o middleware de autentica��o

app.UseAuthorization(); // Adiciona o middleware de autoriza��o

app.MapControllers(); // Mapeia os controladores para as rotas definidas

app.Run(); // Executa a aplica��o
