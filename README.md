# BlackBytesBox.Serilog.AnsiConsoleThemes

A collection of custom ANSI console themes for styled logging output with Serilog. These themes are designed to enhance readability and provide a distinctive visual identity for your log messages.

## Available Themes

- **ClarionDusk**  
  A refined theme with a balanced, elegant color palette. It enhances readability by clearly distinguishing various log levels and essential details, making your log data both informative and visually engaging.

- **ProfessionalNoir**  
  A sleek, modern theme with high contrast and refined styling. It features bright white text, subtle greys, and distinctive colors for each log level, ideal for developers looking for a professional logging experience.

## Features

- **Enhanced Readability:** Carefully curated color schemes to clearly differentiate log levels and message types.
- **Ease of Integration:** Plug-and-play integration with Serilog’s ANSI console sink.
- **Customization:** Extend or modify themes to suit your application's specific visual needs.

## Installation

Install the package via NuGet:

```shell
dotnet add package BlackBytesBox.Serilog.AnsiConsoleThemes
```

### Uasage

Add the desired filters to your application's middleware pipeline in the `Program.cs` or `Startup.cs` file:

```csharp
// Example usage
var logger = new LoggerConfiguration()
    .WriteTo.Console(theme: CustomThemes.ClarionDusk)
    .CreateLogger();
```

## License

This project is licensed under the terms specified in the repository.
