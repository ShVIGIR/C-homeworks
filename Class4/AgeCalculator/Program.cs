// See https://aka.ms/new-console-template for more information
Console.WriteLine("Age calculator");
#region Task 1 - Age calculator
//*Make a method called AgeCalculator
//* The method will have one input parameter, your birthday date
//* The method should return your age
//* Show the age of a user after he inputs a date

//> Note: take into consideration if the birthday is today, after or before today
#endregion
#region Code - Age calculator
Console.WriteLine("Let's calculate your current age!");
Console.WriteLine("Enter your birth date: (dd/mm/yyyy)");
string dateInput = Console.ReadLine();
DateOnly convertedDateInput = DateOnly.Parse(dateInput);
//Console.WriteLine(convertedDateInput);

DateTime currentDate = DateTime.Now;
Console.WriteLine(currentDate);

static void AgeCalculator(DateOnly birthday)
{
    DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now.Date);
    //   Console.WriteLine(currentDate);
    int age = currentDate.Year - birthday.Year;

    if (currentDate.Month > birthday.Month)
    {
        Console.WriteLine($"You are {age}.");
    }
    else if (currentDate.Month == birthday.Month)
    {
        if (currentDate.Day < birthday.Day)
        {
            Console.WriteLine($"You are {--age}.");
        }
        else if (currentDate.Day > birthday.Day)
        {
            Console.WriteLine($"You are {age}.");
        }
        else
        {
            Console.WriteLine($"Happy Birthday! Now you are {age} years old.");
        }
    }
    else
    {
        Console.WriteLine($"You are {--age}.");
    }
}
       
AgeCalculator(convertedDateInput);
#endregion
Console.ReadLine();