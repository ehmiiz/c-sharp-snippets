/*
    Demonstrates:
    - Top level statement
    - Regex pattern matching
    - Ternary operator
    - Collection expression
    - Foreach loop
*/
using System.Text.RegularExpressions;

// Regex pattern and input
string pattern = "^[Ee][Hh][Mm][Ii]{2}[Zz]$";
string[] testStrings = ["Ehmiiz", "ehmiiz", "EhmiiZ", "EHmiiZ", "ehmiIZ", "Ehmiizz", "Banana"];

// Match execution
foreach (string testString in testStrings)
{
    Match match = Regex.Match(testString, pattern);
    string result = match.Success ? $"{testString} matches!" : $"{testString} does not match!";
    Console.WriteLine(result);
}