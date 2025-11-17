// See https://aka.ms/new-console-template for more information
using System; 
Console.WriteLine("is the lecture topic interesting?");
string ans1 = Console.ReadLine();
Console.WriteLine("does one of your friends join?");
string ans2 = Console.ReadLine();
Console.WriteLine("do you have problems with the assignment?");
string ans3 = Console.ReadLine();
bool interesting = ans1 == "y";
bool friendJoins = ans2 == "y";
bool problems = ans3 == "y";
if (interesting && (friendJoins || problems))
{
Console.WriteLine("stay");
}
else
{
Console.WriteLine("go");
}