using ApiFuncional.Data;
using ApiFuncional.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ApiFuncional.Configuration
{
    public static class IdentityConfig
    {
        public static WebApplicationBuilder AddIdentityConfig(this WebApplicationBuilder builder)
        {// Identity é um serviço que permite a autenticação e autorização de usuários
            builder.Services.AddIdentity<IdentityUser, IdentityRole>() //Adiciona o serviço de identidade, que gerencia autenticação e autorização de usuários. IdentityUser: Representa o modelo de usuário, IdentityRole: Representa os papéis (roles) que podem ser atribuídos aos usuários.
                .AddRoles<IdentityRole>() // Habilita o uso de papéis para controle de acesso.
                .AddEntityFrameworkStores<ApiDbContext>(); //Configura o Identity para usar o ApiDbContext como o banco de dados para armazenar informações de usuários e papéis.

            // Pegando o Token e gerando a chave encodada
            var JwtSettingsSection = builder.Configuration.GetSection("JwtSettings"); //Obtém a seção JwtSettings do arquivo de configuração (geralmente appsettings.json).
            builder.Services.Configure<JwtSettings>(JwtSettingsSection);// Registra as configurações do JWT para serem injetadas em outras partes da aplicação.

            var jwtSettings = JwtSettingsSection.Get<JwtSettings>(); 
            var key = Encoding.ASCII.GetBytes(jwtSettings.Segredo);// Segredo é a chave secreta para assinar o token JWT. Converte a chave secreta em um array de bytes, necessário para a validação do token.

            //Configura o esquema de autenticação padrão como JwtBearer.
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme; //Define o esquema usado para autenticar solicitações.
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;//Define o esquema usado para desafios de autenticação.
            }).AddJwtBearer(options => //Configura o suporte para autenticação via JWT.
            {
                options.RequireHttpsMetadata = true;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters //Define os parâmetros de validação do token:
                {
                    IssuerSigningKey = new SymmetricSecurityKey(key), //Chave usada para validar a assinatura do token.
                    ValidateIssuer = true, // Verifica se o emissor do token é válido. Garante que o token foi emitido por uma fonte confiável (por exemplo, o seu servidor de autenticação).
                    ValidateAudience = true,  // Indica se o público do token (Audience) deve ser validado. Garante que o token foi emitido para o público correto (por exemplo, sua aplicação ou serviço).
                    ValidAudience = jwtSettings.Audiencia,// Define o público esperado do token. O público é usado para identificar quem deve consumir o token. Por exemplo, se o token foi emitido para o serviço "API Funcional", ele não deve ser aceito por outro serviço. Esse valor é configurado no arquivo de configuração (appsettings.json) e acessado via jwtSettings.Audiencia
                    ValidIssuer = jwtSettings.Emissor //Define o emissor esperado do token. O emissor identifica quem gerou o token. Isso ajuda a garantir que o token foi emitido por uma autoridade confiável (como o seu servidor de autenticação). Esse valor também é configurado no arquivo de configuração (appsettings.json) e acessado via jwtSettings.Emissor.
                };
            });

            return builder;
        }
    }
}
