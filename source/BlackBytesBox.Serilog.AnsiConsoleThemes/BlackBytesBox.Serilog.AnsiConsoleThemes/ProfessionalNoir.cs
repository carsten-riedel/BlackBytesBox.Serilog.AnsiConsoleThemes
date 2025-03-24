using System.Collections.Generic;

using Serilog.Sinks.SystemConsole.Themes;

namespace BlackBytesBox.Serilog.AnsiConsoleThemes
{
    /// <summary>
    /// Provides custom console themes for styled Serilog output.
    /// </summary>
    public static partial class CustomThemes
    {
        /// <summary>
        /// Gets a fancy professional variant with a sleek, modern aesthetic.
        /// </summary>
        /// <remarks>
        /// This theme is designed for high contrast and refined styling,
        /// featuring bright white text, subtle greys, and distinctive colors for each log level.
        /// </remarks>
        /// <example>
        /// <code>
        /// // Example usage with Serilog:
        /// var logger = new LoggerConfiguration()
        ///     .WriteTo.Console(theme: CustomThemes.ProfessionalNoir)
        ///     .CreateLogger();
        /// </code>
        /// </example>
        public static AnsiConsoleTheme ProfessionalNoir { get; } = new AnsiConsoleTheme(new Dictionary<ConsoleThemeStyle, string>
        {
            [ConsoleThemeStyle.Text] = "\u001b[38;5;255m",          // Bright white for primary text
            [ConsoleThemeStyle.SecondaryText] = "\u001b[38;5;250m",   // Light grey for secondary text
            [ConsoleThemeStyle.TertiaryText] = "\u001b[38;5;245m",    // Muted grey for tertiary text
            [ConsoleThemeStyle.Invalid] = "\u001b[38;5;160m",         // Soft red for invalid content
            [ConsoleThemeStyle.Null] = "\u001b[38;5;59m",             // Dim cyan for null values
            [ConsoleThemeStyle.Name] = "\u001b[38;5;75m",             // Calm teal for names/identifiers
            [ConsoleThemeStyle.String] = "\u001b[38;5;183m",          // Warm lavender for strings
            [ConsoleThemeStyle.Number] = "\u001b[38;5;220m",          // Vibrant yellow for numbers
            [ConsoleThemeStyle.Boolean] = "\u001b[38;5;82m",          // Crisp green for booleans
            [ConsoleThemeStyle.Scalar] = "\u001b[38;5;150m",          // Soft blue for scalar values
            [ConsoleThemeStyle.LevelVerbose] = "\u001b[38;5;244m",    // Subtle grey for verbose logs
            [ConsoleThemeStyle.LevelDebug] = "\u001b[38;5;39m",       // Distinguished blue for debug logs
            [ConsoleThemeStyle.LevelInformation] = "\u001b[38;5;117m",// Refined cyan for informational logs
            [ConsoleThemeStyle.LevelWarning] = "\u001b[38;5;214m",    // Bold orange for warnings
            [ConsoleThemeStyle.LevelError] = "\u001b[38;5;203m",      // Strong red for errors
            [ConsoleThemeStyle.LevelFatal] = "\u001b[38;5;196m\u001b[48;5;52m", // Intense red on a dark background for fatal errors
        });
    }
}
