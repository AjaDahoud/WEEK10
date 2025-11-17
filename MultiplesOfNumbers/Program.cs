using System; 
Console.WriteLine("Enter dividend");
string input1 = Console.ReadLine();

Console.WriteLine("Enter divisor");
string input2 = Console.ReadLine();

decimal.TryParse(input1, out var dividend);
decimal.TryParse(input2, out var divisor);

if (dividend % divisor == 0)
{
    Console.WriteLine("Multiples");
}
else
{
    Console.WriteLine("Not multiples");
}


