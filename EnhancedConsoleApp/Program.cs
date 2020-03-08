using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EnhancedConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Setup Service Configuration
            var collection = new ServiceCollection();
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            var configurationRoot = builder.Build();
            var startup = new Startup(configurationRoot);
            startup.ConfigureServices(collection);

            // Setup Configuration
            collection.AddSingleton(configurationRoot);
            collection.AddLogging(startup.Configure);

            var serviceProvider = collection.BuildServiceProvider();

            // Setup Logging
            startup.Run(serviceProvider);
            
            if (serviceProvider != null && serviceProvider is IDisposable)
            {
                serviceProvider.Dispose();
            }
        }
    }
}
