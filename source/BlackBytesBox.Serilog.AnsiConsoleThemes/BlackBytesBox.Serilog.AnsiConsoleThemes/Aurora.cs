using System.Collections.Generic;

using Serilog.Sinks.SystemConsole.Themes;

namespace BlackBytesBox.Serilog.AnsiConsoleThemes
{
    public static partial class CustomThemes
    {
        public static AnsiConsoleTheme Aurora { get; } = new AnsiConsoleTheme(new Dictionary<ConsoleThemeStyle, string>
        {
            // — Primary text tones —
            [ConsoleThemeStyle.Text] = "\u001b[38;5;251m",               // Off-white
            [ConsoleThemeStyle.SecondaryText] = "\u001b[38;5;244m",               // Soft gray
            [ConsoleThemeStyle.TertiaryText] = "\u001b[38;5;240m",               // Muted slate

            // — Special values & metadata —
            [ConsoleThemeStyle.Invalid] = "\u001b[38;5;203m",               // Coral (errors in data)
            [ConsoleThemeStyle.Null] = "\u001b[38;5;245m",               // Light silver
            [ConsoleThemeStyle.Name] = "\u001b[38;5;109m",               // Aqua (field names)
            [ConsoleThemeStyle.String] = "\u001b[38;5;108m",               // Mint green (strings)
            [ConsoleThemeStyle.Number] = "\u001b[38;5;220m",               // Warm gold (numbers)
            [ConsoleThemeStyle.Boolean] = "\u001b[38;5;150m",               // Pastel green (booleans)
            [ConsoleThemeStyle.Scalar] = "\u001b[38;5;104m",               // Pale blue (scalars)

            // — Log-level prefixes (crisp, distinct) —
            [ConsoleThemeStyle.LevelVerbose] = "\u001b[38;5;245m",            // Muted gray
            [ConsoleThemeStyle.LevelDebug] = "\u001b[38;5;37m",             // Teal
            [ConsoleThemeStyle.LevelInformation] = "\u001b[38;5;75m",             // Sky blue
            [ConsoleThemeStyle.LevelWarning] = "\u001b[38;5;178m",            // Mustard
            [ConsoleThemeStyle.LevelError] = "\u001b[38;5;203m",            // Coral red
            [ConsoleThemeStyle.LevelFatal] = "\u001b[1;38;5;231;48;5;52m",   // Bold white on dark red
        });
    }
}