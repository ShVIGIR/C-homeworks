// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Reverse the case");
#region Task 3 - Reverse the case
//*Given a string, create a method to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
#endregion
#region Code - Revrse the case
Console.WriteLine("Let's make reverse. Enter something: ");
string input = Console.ReadLine();
char[] chars = input.ToCharArray();
//Console.WriteLine(chars.Length);
Console.WriteLine("After reverse made: ");
for (int i = 0; i < chars.Length; i++)
{
    if (char.IsLower(chars[i]))
    {
        Console.Write(char.ToUpper(chars[i]));
    }
    else
    {
        Console.Write(char.ToLower(chars[i]));
    }
}
#endregion
Console.ReadLine();