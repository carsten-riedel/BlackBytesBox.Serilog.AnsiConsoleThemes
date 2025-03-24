using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Serilog;

namespace BlackBytesBox.Serilog.AnsiConsoleThemes.Tests
{
    [TestClass]
    public sealed class VisualInspecionTest
    {
        private static IHost? host;
      
        [ClassInitialize]
        public static async Task ClassInit(TestContext context)
        {

            Log.Logger = new LoggerConfiguration()
             .WriteTo.Console(
             outputTemplate: "{Timestamp:HH:mm:ss.ff} {Level:u3} Ctx: {SourceContext}{NewLine}{Timestamp:HH:mm:ss.ff} {Level:u3} Msg: {Message:l}{NewLine}{Exception}",
             theme: CustomThemes.ClarionDusk)
             .CreateLogger();

            IHostBuilder hostBuilder = Host.CreateDefaultBuilder();
            hostBuilder.ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddSerilog(Log.Logger);
                logging.SetMinimumLevel(LogLevel.Trace);
            });

            // Build and start the host.
            host = hostBuilder.Build();
            await host.RunAsync();
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            if (host != null)
            {
                await host.StopAsync();
            }
        }

        [TestInitialize]
        public void TestInit()
        {
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [TestMethod]
        [DataRow(100)]
        public async Task TestMyMiddlewareIntegration(int delay)
        {
            await Task.Delay(delay);

            Assert.IsTrue(true);
            return;
        }
    }
}