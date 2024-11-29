# C# Snippets by Ehmiiz

This repository contains personal `.cs` files

## The goal

- Demonstrate C# concepts
- Language features
- Common design patterns

## Build the snippets

The purpose is not to have fully functional applications, but they can be built and tested:

1. Locate the snippet you want to compile & run
2. Follow the PowerShell instruction below, line by line

```powershell
$name = "c-sharp-example"
dotnet new console -o $name
Set-Location $Name
# paste the snippet into Program.cs
dotnet run
```
