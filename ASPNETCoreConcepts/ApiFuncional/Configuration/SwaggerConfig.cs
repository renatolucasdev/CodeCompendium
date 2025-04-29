using Microsoft.OpenApi.Models;

namespace ApiFuncional.Configuration
{
    public static class SwaggerConfig
    {
        public static WebApplicationBuilder AddSwaggerConfig(this WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();// Adiciona o suporte para explorar os endpoints
            builder.Services.AddSwaggerGen(c => // Adiciona o Swagger
            {  
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme // Adicionando suporte ao JWT
                {
                    Description = "Insira o token JWT desta maneira: Bearer {seu token}",
                    Name = "Authorization",
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header, // Localização do token
                    Type = SecuritySchemeType.ApiKey// Tipo de autenticação
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement // Define que o esquema de segurança configurado (JWT) será obrigatório para acessar os endpoints protegidos.
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] {} 
                    }
                });
            });

            return builder; // Retorna o WebApplicationBuilder para que a configuração possa ser encadeada com outras chamadas no pipeline de inicialização.
        }
    }
}
