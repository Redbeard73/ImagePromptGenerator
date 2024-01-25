using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ImagePromptGenerator.Services; // Assuming your services are in this namespace

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            // Resolve the service from the service provider
            var service = host.Services.GetRequiredService<IImagePromptService>();
 

            // Keep the console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // Set up a Host for Dependency Injection
        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                {
                    services.AddTransient<IImagePromptService, ImagePromptService>();
                    // Add other services here
                });
    }
}