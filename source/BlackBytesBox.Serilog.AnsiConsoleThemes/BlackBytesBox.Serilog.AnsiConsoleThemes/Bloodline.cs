using System;
using System.Collections.Generic;

using Serilog.Sinks.SystemConsole.Themes;

namespace BlackBytesBox.Serilog.AnsiConsoleThemes
{
    public static partial class CustomThemes
    {
        public static AnsiConsoleTheme Bloodline { get; } = new AnsiConsoleTheme(new Dictionary<ConsoleThemeStyle, string>
            {
                // Core text
                [ConsoleThemeStyle.Text] = "\u001b[1;38;5;231m",         // bold white
                [ConsoleThemeStyle.SecondaryText] = "\u001b[2;38;5;250m",         // dim gray
                [ConsoleThemeStyle.TertiaryText] = "\u001b[3;38;5;250m",         // italic gray

                // Special values
                [ConsoleThemeStyle.Invalid] = "\u001b[5;38;5;196m",         // blink bright red
                [ConsoleThemeStyle.Null] = "\u001b[2;38;5;131m",         // dim dark red

                // Structural
                [ConsoleThemeStyle.Name] = "\u001b[4;38;5;231m",         // underline white
                [ConsoleThemeStyle.String] = "\u001b[1;38;5;196m",         // bold red
                [ConsoleThemeStyle.Number] = "\u001b[7;38;5;231;48;5;196m",// reverse white/red
                [ConsoleThemeStyle.Boolean] = "\u001b[1;38;5;196m",         // bold red
                [ConsoleThemeStyle.Scalar] = "\u001b[2;38;5;231m",         // dim white

                // Log levels
                [ConsoleThemeStyle.LevelVerbose] = "\u001b[2;38;5;244m",       // dim slate
                [ConsoleThemeStyle.LevelDebug] = "\u001b[3;38;5;244m",       // italic slate
                [ConsoleThemeStyle.LevelInformation] = "\u001b[1;38;5;231m",       // bold white
                [ConsoleThemeStyle.LevelWarning] = "\u001b[1;4;38;5;196m",     // bold & underline red
                [ConsoleThemeStyle.LevelError] = "\u001b[1;5;38;5;196m",     // bold & blink red
                [ConsoleThemeStyle.LevelFatal] = "\u001b[1;4;5;97;41m",      // bold, underline, blink, white-on-dark-red
            });
    }
}