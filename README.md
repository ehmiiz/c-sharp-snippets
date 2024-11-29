# C# Snippets by Ehmiiz

This repository contains personal `.cs` files

## The goal

- Demonstrate C# concepts
- Language features
- Common design patterns

## Build the snippets

The purpose is not to have fully functional applications, but they can be built and tested:

1. Select the snippet you want to compile & run
2. Copy the code into your clipboard
3. Run the Invoke-CSSnippet.ps1 file

```powershell
$name = "c-sharp-example"
dotnet new console -o $name
Set-Location $Name
Get-Clipboard > Program.cs
dotnet run
```
