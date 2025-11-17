// See https://aka.ms/new-console-template for more information

string userInput1 = Console.ReadLine();
string userInput2 = Console.ReadLine();
int.TryParse(userInput1, out var number1 );
int.TryParse(userInput2, out var number2);

Console.WriteLine(number1+number2);
Console.WriteLine(number1*number2);
Console.WriteLine(number1-number2);
Console.WriteLine(number1/number2);
Console.WriteLine(number1%number2);





