using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EnhancedConsoleApp
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMyService, MyService>();
        }


        public void Configure(ILoggingBuilder loggingBuilder)
        {
            loggingBuilder.AddConsole();
            loggingBuilder.SetMinimumLevel(LogLevel.Information);
        }

        public void Run(IServiceProvider provider)
        {
            var service = provider.GetService<IMyService>();
            service.MyServiceMethod();
        }


    }
}