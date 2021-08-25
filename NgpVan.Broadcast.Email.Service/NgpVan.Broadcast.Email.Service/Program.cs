using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Reflection;

namespace NgpVan.Broadcast.Email.Service
{
    public class Program
    {
        private static ILogger<Program> _logger;
        public const string SERVICE_NAME = "BroadcastEmail";

        public static void Main(string[] args)
        {
            var host = BuildHost(args);
            _logger = host.Services.GetRequiredService<ILogger<Program>>();

            _logger.LogInformation("***********************************************************\n"
                                   + $"Starting {SERVICE_NAME} Service - {Version}\n"
                                   + "***********************************************************");

            try
            {
                host.Run();
            }
            catch (Exception ex)
            {
                _logger.LogCritical("***********************************************************\n"
                                    + $"Ending {SERVICE_NAME} Service - {Version}\n"
                                    + "***********************************************************\n");
                _logger.LogCritical(ex, "Application startup failed.");
                _logger.LogCritical("***********************************************************");
            }
        }

        public static IHost BuildHost(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((configurationBuilder) =>
                {
                    configurationBuilder
                        .AddKeyPerFile(directoryPath: "/var/config", optional: true)
                        .AddKeyPerFile(directoryPath: "/var/secrets", optional: true);
                })
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webHostBuilder =>
                {
                    webHostBuilder
                        .UseContentRoot(Directory.GetCurrentDirectory())
                        .UseIISIntegration()
                        .UseStartup<Startup>();
                })
                .Build();

        public static Version Version => Assembly.GetAssembly(typeof(Program)).GetName().Version;

        public static void OnShutdown()
        {
            _logger.LogInformation("***********************************************************");
            _logger.LogInformation($"Stopping {SERVICE_NAME} Service - {Version}");
            _logger.LogInformation("***********************************************************");
        }
    }
}
