using ApiFuncional.Configuration;

var builder = WebApplication.CreateBuilder(args);

//Extension methods criados para configurar os serviços nas classes Config
builder
    .AddApiConfig() 
    .AddCorsConfig()
    .AddSwaggerConfig()
    .AddDbContextConfig()
    .AddIdentityConfig();

var app = builder.Build();

if (app.Environment.IsDevelopment()) // Define configurações específicas para o ambiente de desenvolvimento
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("Development");
}
else // Define configurações específicas para o ambiente de produção
{
    app.UseCors("Production");
}

app.UseHttpsRedirection(); // Adiciona o middleware para redirecionar requisições HTTP para HTTPS
// Não se pode inverter a order dos middlewares de autenticação e autorização
app.UseAuthentication(); // Adiciona o middleware de autenticação

app.UseAuthorization(); // Adiciona o middleware de autorização

app.MapControllers(); // Mapeia os controladores para as rotas definidas

app.Run(); // Executa a aplicação
