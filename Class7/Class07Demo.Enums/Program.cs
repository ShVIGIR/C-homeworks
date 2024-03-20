// See https://aka.ms/new-console-template for more information
using Class07Demo.Enums.Enums;

Console.WriteLine("Hello, World!");
#region Methods
static void isWeekend (Days day)
{
    if(day == Days.Saturday || day == Days.Sunday)
    {
        Console.WriteLine($"Yesss!! it is {day}!");
    }
    else
    {
        Console.WriteLine($"Nooo! It is {day}.");
    }
}
#endregion
#region Using enums
Days monday = Days.Monday;
isWeekend(monday);
Days lala = Days.Sunday;
isWeekend(lala);

#endregion
#region Converting enums
int num = 3;
Days dayThree = (Days)num;
isWeekend(dayThree);
Console.WriteLine(dayThree);

Days dayFour = Days.Thursday;
int _dayFour = (int)dayFour;
Console.WriteLine(_dayFour);


Days dayFive = Days.Friday;
isWeekend(dayFive);
string _dayFive = dayFive.ToString();
isWeekend(dayFive);
Console.WriteLine(_dayFive);


Console.WriteLine("Enter enum:");
string input = Console.ReadLine();
if (Enum.TryParse(input, out Days someDayInput))
{
    Console.WriteLine($"You enter enum: {someDayInput}.");
}
else
{
    Console.WriteLine("Error!!");
};
#endregion