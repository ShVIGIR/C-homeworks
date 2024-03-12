// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Date and time format");
#region Task 2 - Date and time formatting
//Write a method that formats a given date and time as a string in a specific format.
//* Get the needed inputs from screen.
//> Allowed formats: "MM/dd/yyyy", "MM/dd/yyyy hh:mm:ss", "dddd, dd MMMM yyyy HH:mm:ss", "MM.dd.yyyy"
//> Bonus: Create separate method that validates whether the entered format is allowed
#endregion
#region Code - Date and time format

Console.WriteLine("Enter date, then enter time:");
string dateAndTime = Console.ReadLine();
bool dateTimeConverted = DateTime.TryParse(dateAndTime, out  DateTime dateTime);
//Console.WriteLine(dateTimeConverted);

string formatOne = dateTime.ToString("MM/dd/yyyy hh:mm:ss");
//Console.WriteLine(formatOne);
string formatTwo = dateTime.ToString("MM/dd/yyyy");
//Console.WriteLine(formatTwo);
string formatThree = dateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");
//Console.WriteLine(formatThree);
string formatFour = dateTime.ToString("MM.dd.yyyy");
//Console.WriteLine(formatFour);

string[] formatsAllowed = {formatOne, formatTwo, formatThree, formatFour};

if (!dateTimeConverted)
{
    Console.WriteLine("Enter valide date!");
  
}
else {
    Console.WriteLine("Allowed formats: No.1 \"MM/dd/yyyy\",No.2 \"MM/dd/yyyy hh:mm:ss\",No.3 \"dddd,No.4 dd MMMM yyyy HH:mm:ss\", \"MM.dd.yyyy\"");
    string input = Console.ReadLine();
    for (int i = 0; i < formatsAllowed.Length; i++) {
        if (input == "1")
        {
            Console.WriteLine(formatOne);
            break;
        }
        if (input == "2")
        {
            Console.WriteLine(formatTwo);
            break;
        }
        if (input == "3") 
        {
            Console.WriteLine(formatThree);
            break;
        }
        if (input == "4")
        {
            Console.WriteLine(formatFour);
            break;
        }
        else
        {
            Console.WriteLine("Invalid number format.");
            break;
        }
    }
}

#endregion
Console.ReadLine();
