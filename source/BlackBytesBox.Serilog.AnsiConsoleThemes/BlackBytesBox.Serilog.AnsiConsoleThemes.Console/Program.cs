using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Serilog;
using Serilog.Events;
using Serilog.Filters;

namespace BlackBytesBox.Serilog.AnsiConsoleThemes.Console
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .MinimumLevel.Verbose()
                .WriteTo.Console(
                restrictedToMinimumLevel: LogEventLevel.Verbose,
                theme: AnsiConsoleThemes.CustomThemes.CodingNight
                ).CreateLogger();

            IHostBuilder hostBuilder = Host.CreateDefaultBuilder();
            hostBuilder.ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddSerilog(Log.Logger);
                logging.SetMinimumLevel(LogLevel.Trace);
            });

            // Build and start the host.
            var host = hostBuilder.Build();

            // Log a message at every level with structured data.
            Log.Logger.Verbose("Verbose message: Starting operation with parameters {@Parameters}", new { Param1 = "Value1", Param2 = 123 });
            Log.Logger.Debug("Debug message: Processing step {StepNumber}", 1);
            Log.Logger.Information("Information: Hello, Serilog! User {UserId} logged in at {LoginTime}", "user123", DateTime.Now);
            Log.Logger.Warning("Warning: Disk space is low. Available: {AvailableSpace} MB", 512);
            Log.Logger.Error(new Exception("Simulated exception"), "Error: An exception occurred while processing request for user {UserId}", "user456");
            Log.Logger.Fatal("Fatal: System crash imminent. System details: {@SystemDetails}", new { System = "MainSystem", Status = "Critical" });

            await host.RunAsync();
        }
    }
}