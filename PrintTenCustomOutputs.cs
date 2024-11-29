/*
    By Emil Larsson
    Simple program to demonstrate C#'s syntax and features

    Demonstrates:
    - Multi line comments
    - Single line comments
    - Ask user for input
    - Assign variable types
    - Avoid debugger exceptions
    - Creating a method
    - For loops
    - Switch statement
    - String interpolation (avoid concatination as always)
*/
using System.Diagnostics;

// Demonstrates how to gather information from the user
// and variable declaration, allowing a nullable value (?)
Console.WriteLine("Enter something to print 10 times: ");
string? printThis = Console.ReadLine();

// Avoids debugger exceptions while working with CLIs
if (!Debugger.IsAttached)
{
    Console.Clear();
}

// Method that uses a switch statement
string GetCounterSuffix(int number)
{
    return number switch
    {
        1 => "st",
        2 => "nd",
        3 => "rd",
        _ => "th",
    };
}

// For loop that finally outputs the result 
for (int i = 1; i < 11; i++)
{
    string counterSuffix = GetCounterSuffix(i);
    string loopMsg = $"{printThis}: the {i}{counterSuffix} time!";
    Console.WriteLine(loopMsg);
}