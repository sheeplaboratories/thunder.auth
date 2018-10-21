using System;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace thunder.auth.Extensions
{
    public static class LoggerExtensions
    {

        public static IServiceCollection AddMuramasaLogger(this IServiceCollection services)
        {
            var serilog = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .Enrich.FromLogContext()
                .WriteTo.File(@"muramasa_log.txt");
            return services;
        }
    }
}
