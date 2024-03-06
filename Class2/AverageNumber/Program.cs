// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;
using System;

Console.WriteLine("Average Number");
#region Task 2 - Average Number
//Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.
//* Test Data:
//*Enter the First number: 10
//* Enter the Second number: 15
//* Enter the third number: 20
//* Enter the four number: 30
//* Expected Output:
//*The average of 10, 15, 20 and 30 is: 18
#endregion
#region Code - Average Number
Console.WriteLine("This app will calculate average value of 4 numbers.");
Console.WriteLine("Enter first number:");
string numOne = Console.ReadLine();
Console.WriteLine("Enter second number:");
string numTwo = Console.ReadLine();
Console.WriteLine("Enter third number:");
string numThree = Console.ReadLine();
Console.WriteLine("Enter fourth number:");
string numFour = Console.ReadLine();

float averageNumber = 0f;

bool isParsedFirst = float.TryParse(numOne, out float firstNumber);
bool isParsedSecond = float.TryParse(numTwo, out float secondNumber);
bool isParsedThird = float.TryParse(numThree, out float thirdNumber);
bool isParsedFourth = float.TryParse(numFour, out float fourthNumber);

if(!isParsedFirst || !isParsedSecond || !isParsedThird || !isParsedFourth)
{
    Console.WriteLine("Enter valid numbers!");
}
else
{
    averageNumber = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
    Console.WriteLine("The average number of " + firstNumber + ", " + secondNumber + ", " + thirdNumber + ", " + fourthNumber + " is " + averageNumber);
}
#endregion