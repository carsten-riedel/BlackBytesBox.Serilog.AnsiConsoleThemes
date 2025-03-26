using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Serilog.Sinks.SystemConsole.Themes;

namespace BlackBytesBox.Serilog.AnsiConsoleThemes
{
    /// <summary>
    /// Provides custom console themes for styled Serilog output.
    /// </summary>
    public static partial class CustomThemes
    {
        /// <summary>
        /// VisualStudioNight: A custom Serilog console theme that more closely emulates
        /// the default Visual Studio dark style colors.
        /// </summary>
        /// <remarks>
        /// Colors have been chosen to reflect typical Visual Studio dark theme color
        /// values, approximated for the 256-color xterm palette. Adjust as needed.
        /// </remarks>
        /// <returns>An AnsiConsoleTheme configured with Visual Studio-inspired colors.</returns>
        /// <example>
        /// <code>
        /// // Example usage:
        /// Log.Logger = new LoggerConfiguration()
        ///     .MinimumLevel.Verbose()
        ///     .WriteTo.Console(theme: CustomThemes.CodingNight)
        ///     .CreateLogger();
        /// </code>
        /// </example>
        public static AnsiConsoleTheme CodingNight { get; } = new AnsiConsoleTheme(new Dictionary<ConsoleThemeStyle, string>
        {
            // Regular text: near #D4D4D4
            [ConsoleThemeStyle.Text] = "\u001b[38;5;252m",         // approx. #D0D0D0
                                                                   // Secondary text: near #808080
            [ConsoleThemeStyle.SecondaryText] = "\u001b[38;5;244m", // #808080
                                                                    // Tertiary text: a darker gray
            [ConsoleThemeStyle.TertiaryText] = "\u001b[38;5;240m",  // #585858
                                                                    // Invalid (e.g. exceptions): near #F44747
            [ConsoleThemeStyle.Invalid] = "\u001b[38;5;203m",       // #FF5F5F
                                                                    // Null values: a medium gray
            [ConsoleThemeStyle.Null] = "\u001b[38;5;242m",          // #767676
                                                                    // Property/field names: near #569CD6
            [ConsoleThemeStyle.Name] = "\u001b[38;5;74m",           // #5FAFDF
                                                                    // String values: near #CE9178
            [ConsoleThemeStyle.String] = "\u001b[38;5;173m",        // #D7875F
                                                                    // Numbers: near #B5CEA8
            [ConsoleThemeStyle.Number] = "\u001b[38;5;150m",        // #AFD787
                                                                    // Booleans: near #4EC9B0
            [ConsoleThemeStyle.Boolean] = "\u001b[38;5;72m",        // #5FD7AF
                                                                    // Other scalar values
            [ConsoleThemeStyle.Scalar] = "\u001b[38;5;72m",         // #5FD7AF
                                                                    // Verbose logs: gray
            [ConsoleThemeStyle.LevelVerbose] = "\u001b[38;5;244m",  // #808080
                                                                    // Debug logs: near #9CDCFE
            [ConsoleThemeStyle.LevelDebug] = "\u001b[38;5;117m",    // #87D7FF
                                                                    // Info logs: a soft gold/brown
            [ConsoleThemeStyle.LevelInformation] = "\u001b[38;5;179m", // #D7AF5F
                                                                       // Warning logs: near #DCDCAA
            [ConsoleThemeStyle.LevelWarning] = "\u001b[38;5;187m",  // #D7D7AF
                                                                    // Error logs: near #F44747
            [ConsoleThemeStyle.LevelError] = "\u001b[38;5;203m",    // #FF5F5F
                                                                    // Fatal logs: bright foreground on dark red background
            [ConsoleThemeStyle.LevelFatal] = "\u001b[38;5;203m\u001b[48;5;52m", // #FF5F5F on #5F0000
        });
    }


}
