// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System;

Console.WriteLine("Swap Numbers");
#region Task 3 - Swap Numbers
//Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value.
//Please find example below:
//*Test Data:
//*Input the First Number: 5
//* Input the Second Number: 8
//* Expected Output:
//*After Swapping:
//*First Number: 8
//* Second Number: 5
#endregion
#region Code - Swap Numbers
Console.WriteLine("This is a SWAP application for swapping values between two numbers.");
Console.WriteLine("Enter first number:");
string numOne = Console.ReadLine();
Console.WriteLine("Enter second number:");
string numTwo = Console.ReadLine();

bool isParsedFirst = double.TryParse(numOne, out double firstNumber);
bool isParsedSecond = double.TryParse(numTwo, out double secondNumber);

if(isParsedFirst && isParsedSecond)
{
    double newNumber = firstNumber;
    firstNumber = secondNumber;
    secondNumber = newNumber;
    Console.WriteLine("The numbers were swaped. Now, the first number is: " + firstNumber + " and the second number is: " + secondNumber + ".");
}
else
{
    Console.WriteLine("Enter valid numbers!");
}
#endregion
