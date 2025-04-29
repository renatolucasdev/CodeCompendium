namespace ApiFuncional.Configuration
{
    public static class CorsConfig
    {
        public static WebApplicationBuilder AddCorsConfig(this WebApplicationBuilder builder)
        {
            builder.Services.AddCors(options => //CORS is implemented by browser to allow or restrict resources requested from another domain
            {
                options.AddPolicy("Development", builder => //Add CORS policy for development
                            builder
                                .AllowAnyOrigin()
                                .AllowAnyMethod()
                                .AllowAnyHeader());

                options.AddPolicy("Production", builder => //Add CORS policy for production
                            builder
                                .WithOrigins("https://localhost:9000")
                                .WithMethods("POST")
                                .AllowAnyHeader());
            });

            return builder;
        }
    }
}
