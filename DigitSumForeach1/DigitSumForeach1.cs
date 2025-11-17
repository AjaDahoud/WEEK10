// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("Enter an integer");
string input = Console.ReadLine();
int sum = 0;
foreach (char c in input)
{
int.TryParse(c.ToString(), out int digit);
sum += digit;
}
Console.WriteLine("Sum: " + sum);

