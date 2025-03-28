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

## ClarionDusk

![image](https://github.com/user-attachments/assets/6e192f1b-c83b-45a4-a285-672a16c6b0a4)

## ProfessionalNoir

![image](https://github.com/user-attachments/assets/9aad98e9-be3c-4f41-86b2-f22574c4ffde)

## CodeingNight

![image](https://github.com/user-attachments/assets/d01f48df-998c-4b4b-b99a-da4a2d09e802)



## Third-Party Notices and Reports

Access key documentation and reports detailing the use and status of third-party components, software dependencies, and audit results:

- **[Third Party Notices](https://github.com/carsten-riedel/BlackBytesBox.Serilog.AnsiConsoleThemes/blob/main/docs/production/ReportThirdPartyNotices.txt)**\
  A complete list of third-party libraries and their licensing terms.

- **[Bill of Materials](https://github.com/carsten-riedel/BlackBytesBox.Serilog.AnsiConsoleThemes/blob/main/docs/production/ReportBillOfMaterials.md)**\
  An itemized overview of all included components, including versions and sources.

- **[Outdated Packages Report](https://github.com/carsten-riedel/BlackBytesBox.Serilog.AnsiConsoleThemes/blob/main/docs/production/ReportOutdated.md)**\
  Lists legacy or outdated dependencies that may require updating.

- **[Deprecated Components Report](https://github.com/carsten-riedel/BlackBytesBox.Serilog.AnsiConsoleThemes/blob/main/docs/production/ReportDeprecated.md)**\
  Identifies components flagged as deprecated and planned for removal.

- **[Vulnerability Report](https://github.com/carsten-riedel/BlackBytesBox.Serilog.AnsiConsoleThemes/blob/main/docs/production/ReportVulnerabilities.md)**\
  Documents known vulnerabilities detected in current dependencies and their impact.
