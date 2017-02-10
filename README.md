# dotnet-clean [![NuGet version](https://badge.fury.io/nu/DotNet.Cleaner.Tools.svg)](https://www.nuget.org/packages/DotNet.Cleaner.Tools)

A .NET Core CLI extension tool for cleaning projects. Recursively deletes all "bin" and "obj" folder starting from "." folder (unlimited depth).

## How to use
Add as a tool to your project.json
```json
"tools": {
    "DotNet.Cleaner.Tools": "1.0.0-*"
}
```
Restore dependencies to install
```bash
dotnet restore
```

## Usage
Run the following command
```bash
dotnet clean
```

## Issue Reporting

If you have found a bug or if you have a feature request, please report them at this repository issues section.

## Authors

[Toni Solarin-Sodara](https://github.com/tsolarin)
[Nemanja Milosevic](https://github.com/nmilosev)

## License

This project is licensed under the MIT license. See the [LICENSE](LICENSE) file for more info.
