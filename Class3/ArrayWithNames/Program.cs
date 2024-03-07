// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

Console.WriteLine("Array with names");
#region Task 4 - Array with names (task 6)
//Create an array with names
//Give an option to the user to enter a name from the keyboard
//After entering the name put it in the array
//Ask the user if they want to enter another name (Y/N)
//Do the same process over and over until the user enters N
//Print all the names after user enters N
#endregion
#region Code - Array with names (task 6)
string[] arrayOfNames = { "Murat", "Radica", "Sara", "Simeon" };

Console.WriteLine("Add name to the list: ");
Array.Resize(ref arrayOfNames, arrayOfNames.Length + 1);
arrayOfNames[arrayOfNames.Length - 1] = Console.ReadLine();

Console.WriteLine("The new name has been added.");

do
{
    Console.WriteLine("Do you want to add another name? Choose: Y/N");
    string inputChar = Console.ReadLine();
    if (inputChar == "Y" || inputChar == "y")
    {
        Array.Resize(ref arrayOfNames, arrayOfNames.Length + 1);
        arrayOfNames[arrayOfNames.Length - 1] = Console.ReadLine();
        Console.WriteLine("The new item has been added.");
    }
    else if (inputChar == "N" || inputChar == "n")
    {
        Console.WriteLine("The updated list of names:");
        foreach (string name in arrayOfNames)
        {
        Console.WriteLine( name);

        }
        break;
    }
    else
    {
        Console.WriteLine("Invalid input. Choose 'Y' for YES or 'N' for NO!");
        continue;
    }
}
while (true);
Console.ReadLine();
#endregion