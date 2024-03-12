// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Basic E-Mail Validation");
#region Task 4 - Basic E-Mail Validation
//*Create a method that accepts a string, checks if it's a valid email address and returns either true or false, depending on the evaluation.

// * The string must contain an `@` character.
// * The string must contain a `.` character.
//* The `@` must have at least one character in front of it.
//    * ex. `"e@mail.com"` is valid, while `"@email.com"` is invalid.
// * The `.` and the `@` must be in the appropriate places.
//   * ex. `"hello.email@com"` is invalid while `"john.smith@email.com"` is valid.

//* If the string passes these tests, it's considered a valid email address.
#endregion
#region Code - Basic E-Mail Validation
Console.WriteLine("Enter valid e-mail adress: ");
string email = Console.ReadLine();

static bool mailIsValid (string email)
{
    int dot = email.IndexOf(".");
    int monkey = email.IndexOf("@");
    if(monkey < 1 || monkey > email.Length - 1)
    {
        return false;
    }
    if(dot <= monkey  + 1 || dot > email.Length - 1)
    {
        return false;
    }
    return true;
}

if (mailIsValid(email))
{
    Console.WriteLine("Mail is valid.");
}
else
{
    Console.WriteLine("Enter valid mail!");
}


    #endregion
    Console.ReadLine();


