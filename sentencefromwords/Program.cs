// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("enter words of a sentence one by one includin punctuation:");
string sentence = "";
while (true)
{
string word = Console.ReadLine();
sentence += word + " ";
if (word.EndsWith(".") || word.EndsWith("!") || word.EndsWith("?"))
{
break;
}
}
Console.WriteLine(sentence);