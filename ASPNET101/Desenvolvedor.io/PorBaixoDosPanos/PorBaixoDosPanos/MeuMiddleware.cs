using Serilog;
using System.Diagnostics;

namespace PorBaixoDosPanos
{
    public class TemplateMiddleware
    {
        private readonly RequestDelegate _next;

        public TemplateMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            //Faz algo antes

            //Chama o próximo middleware no pipeline
            await _next(context);

            //Faz algo depois
        }
    }

    public class LogTempoMiddleware
    {
        private readonly RequestDelegate _next;
        public LogTempoMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            //Faz algo antes
            var sw = Stopwatch.StartNew();

            //Chama o próximo middleware no pipeline
            await _next(context);

            sw.Stop();

            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            Log.Information($"A execução demorou {sw.Elapsed.TotalMilliseconds}ms ({sw.Elapsed.TotalSeconds}) segundos");
        }
    }

    //Encapsulando configuração do WebApplicationBuilder e WebApplication através de extesion methods.
    //Dessa forma, o código fica mais limpo, organizado e escalável (preserva a Program.cs). Existem pacotes Nuget só de extension methods.
    public static class SerilogExtensions
    {
        public static void AddSerilog(this WebApplicationBuilder builder)
        {   //Aqui podem ser inseridas várias configurações do Serilog que serão resolvidas por uma única linha na Program.cs
            builder.Host.UseSerilog();
        }
    }

    public static class LogTempoMiddlewareExtensions
    {
        public static void UseLogTempo(this WebApplication app)
        {
            //Aqui podem ser inseridas várias configurações do Serilog que serão resolvidas por uma única linha na Program.cs
            app.UseMiddleware<LogTempoMiddleware>();
        }
    }
}