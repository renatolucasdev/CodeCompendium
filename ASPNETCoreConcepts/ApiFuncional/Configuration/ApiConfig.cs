namespace ApiFuncional.Configuration
{
    public static class ApiConfig
    {
        public static WebApplicationBuilder AddApiConfig(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers()
                            .ConfigureApiBehaviorOptions(options =>
                            {
                                options.SuppressModelStateInvalidFilter = true; // Desabilita o filtro padrão que retorna um BadRequest quando o ModelState é inválido.
                            });

            return builder;
        }
    }
}
