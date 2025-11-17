// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("Enter an integer");
string input = Console.ReadLine();
int.TryParse(input, out int number);
int sum = 0;
while (number > 0)
{
int digit = number % 10;
sum += digit;
number /= 10;
}
Console.WriteLine("Sum: " + sum);

