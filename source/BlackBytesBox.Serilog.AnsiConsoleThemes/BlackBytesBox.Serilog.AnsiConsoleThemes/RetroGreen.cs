using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Serilog.Sinks.SystemConsole.Themes;

namespace BlackBytesBox.Serilog.AnsiConsoleThemes
{
    /// <summary>
    /// Provides custom console themes for styled Serilog output.<br/>
    /// &lt;remarks&gt;Add additional themes here as required.&lt;/remarks&gt;
    /// </summary>
    public static partial class CustomThemes
    {
        /// <summary>
        /// RetroGreen: evokes the look of monochrome CRT terminals circa 1980-1990.<br/>
        /// &lt;remarks&gt;Ideal when you need that nostalgic hacker-movie vibe while retaining clear log-level separation.&lt;/remarks&gt;
        /// </summary>
        /// <returns>An <see cref="AnsiConsoleTheme"/> configured with green-centric ANSI colors.</returns>
        /// <example>
        /// &lt;code&gt;
        /// Log.Logger = new LoggerConfiguration()
        ///     .WriteTo.Console(theme: CustomThemes.RetroGreen)
        ///     .CreateLogger();
        /// &lt;/code&gt;
        /// </example>
        public static AnsiConsoleTheme RetroGreen { get; } = new AnsiConsoleTheme(
              new Dictionary<ConsoleThemeStyle, string>
              {
                  [ConsoleThemeStyle.Text] = "\u001b[38;5;34m",  // medium green
                  [ConsoleThemeStyle.SecondaryText] = "\u001b[38;5;29m",
                  [ConsoleThemeStyle.TertiaryText] = "\u001b[38;5;22m",

                  [ConsoleThemeStyle.Invalid] = "\u001b[38;5;82m\u001b[48;5;22m",
                  [ConsoleThemeStyle.Null] = "\u001b[38;5;22m",
                  [ConsoleThemeStyle.Name] = "\u001b[38;5;76m",
                  [ConsoleThemeStyle.String] = "\u001b[38;5;70m",
                  [ConsoleThemeStyle.Number] = "\u001b[38;5;34m",
                  [ConsoleThemeStyle.Boolean] = "\u001b[38;5;76m",
                  [ConsoleThemeStyle.Scalar] = "\u001b[38;5;70m",

                  [ConsoleThemeStyle.LevelVerbose] = "\u001b[38;5;22m",
                  [ConsoleThemeStyle.LevelDebug] = "\u001b[38;5;29m",
                  [ConsoleThemeStyle.LevelInformation] = "\u001b[38;5;34m",
                  [ConsoleThemeStyle.LevelWarning] = "\u001b[38;5;70m",
                  [ConsoleThemeStyle.LevelError] = "\u001b[38;5;76m\u001b[48;5;22m",
                  [ConsoleThemeStyle.LevelFatal] = "\u001b[38;5;231m\u001b[48;5;28m",  // white on dark green
              });
    }
}