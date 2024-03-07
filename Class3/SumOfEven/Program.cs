// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Sum of evan");

#region Task 1 - Sum of Evan
//Make a console application called SumOfEven. Inside it create an array of 6 integers. Get numbers from the input, find and print the sum of the even numbers from the array.
#endregion

#region Code - Sum of Evan
Console.WriteLine("Enter integer no.1:");
string inputOne = Console.ReadLine();
bool oneIsParsed = int.TryParse(inputOne, out int firstNumber);

Console.WriteLine("Enter integer no.2:");
string inputTwo = Console.ReadLine();
bool twoIsParsed = int.TryParse(inputTwo, out int secondNumber);

Console.WriteLine("Enter integer no.3:");
string inputThree = Console.ReadLine();
bool threeIsParsed = int.TryParse(inputThree, out int thirdNumber);

Console.WriteLine("Enter integer no.4:");
string inputFour = Console.ReadLine();
bool fourthIsParsed = int.TryParse(inputFour, out int fourthNumber);

Console.WriteLine("Enter integer no.5:");
string inputFive = Console.ReadLine();
bool fiveIsParsed = int.TryParse(inputFive, out int fifthNumber);

Console.WriteLine("Enter integer no.6:");
string inputSix = Console.ReadLine();
bool sixIsPased = int.TryParse(inputSix, out int sixthNumber);

int[] intArray = { firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber, sixthNumber};
int result = 0;

if (!oneIsParsed || !twoIsParsed || !threeIsParsed || !fourthIsParsed || !fiveIsParsed || !sixIsPased)
{
    Console.WriteLine("Enter valid INTEGERS!");
}
else
{
    for (int i = 0; i < intArray.Length; i++)
    {
      
        if (intArray[i] % 2 == 1)
        {
            continue;
            Console.WriteLine(intArray[i]);
        }
        if (intArray[i] % 2 == 0)
        { 
            result += intArray[i];
            
        }
    }
    Console.WriteLine("The sum of this even numbers is: " + result);
}
Console.ReadLine();
#endregion