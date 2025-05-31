using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using TaskLibrary;

namespace Homework_8
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();

            var logfile = new NLog.Targets.FileTarget("logfile")
            {
                FileName = "log.txt"
            };

            var services = new ServiceCollection();

            ConfigurateServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var form = serviceProvider.GetRequiredService<AddTaskForm>();
                Application.Run(form);
            }
        }

        private static void ConfigurateServices(ServiceCollection services)
        {
            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.ClearProviders();
                loggingBuilder.SetMinimumLevel(LogLevel.Trace);
                loggingBuilder.AddNLog("nlog.config");
            });

            services.AddSingleton<TaskLib>();
            services.AddTransient<AddTaskForm>();
            services.AddTransient<CheckAndEditTaskForm>();
        }
    }
}