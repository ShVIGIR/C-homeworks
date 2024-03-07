// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Student Group");

#region Task 2 - Student Group
//*Make a new console application called StudentGroup
//* Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names. 
//* Get a number from the console between 1 and 2 and print the students from that group in the console.
#endregion
#region Code - Student Group
string[] studentsG1 = { "Mario", "Filip", "Gjordje", "Aneta", "Ivan" };
string[] studentsG2 = { "Nikola", "Simeon", "Sara", "Murat", "Marko" };

Console.WriteLine("Enter student group: ( there are 1 and 2 )");
string input = Console.ReadLine();

bool inputIsValid = int.TryParse(input, out int number);

if (!inputIsValid)
{
    Console.WriteLine("Enter valid numbers!");
}
else
{
    if (input == "1")
    {
        Console.WriteLine("The students in G" + input + " are: ");
        foreach (string student in studentsG1)
        {
            Console.WriteLine(student);
        }
    }
    else if (input == "2")
    {
        Console.WriteLine("The students in G" + input + " are: ");
        foreach (string student in studentsG2)
        { 
            Console.WriteLine(student);
        }
    }
    else
    {
        Console.WriteLine("There are only group 1 and 2!");
    }
}
Console.ReadLine();
#endregion