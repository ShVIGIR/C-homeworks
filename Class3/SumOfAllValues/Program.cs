// See https://aka.ms/new-console-template for more information
Console.WriteLine("Sum of all values");
#region Task 3 - Sum of all numbers (task 5)
//Declare a new array of integers with 5 elements.
//Initialize the array elements with values from input.
//Sum all the values and print the result in the console.
#endregion
#region Code - Sum of all numbers (task 5)
int[] arrayOfNumbers = new int [5];

int sumOfAllNumbers = 0;

Console.WriteLine("Enter 5 integers, one by one: ");
for (int i = 0; i < 5; i++)
{
    Console.Write($"Number {i + 1}: ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        arrayOfNumbers[i] = number;
    }
    else
    {
        Console.WriteLine("Enter valid integer!");
        i--;
    }
}
foreach (int number in arrayOfNumbers)
{
    sumOfAllNumbers += number;
}
Console.WriteLine("Sum of all integers is: " + sumOfAllNumbers);
Console.ReadLine();
#endregion