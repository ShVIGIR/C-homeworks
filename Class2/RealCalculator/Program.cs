// See https://aka.ms/new-console-template for more information
Console.WriteLine("Real Calculator");
#region Task 1 - Real Calculator
//Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.
//* Test Data:
//* Enter the First number: 10
//* Enter the Second number: 15
//* Enter the Operation: +
//* Expected Output:
//* The result is: 25
#endregion
#region Code - Real Calculator
Console.WriteLine("Let calculate two numbers!");
Console.WriteLine("Enter first number:");
string numOne = Console.ReadLine();
Console.WriteLine("Enter second number:");
string numTwo = Console.ReadLine();
Console.WriteLine("Choose the operation: '+', '-', '*', '/'. Enter operator:");
string operation = Console.ReadLine();

float result = 0f;

bool isParsedFirst = float.TryParse(numOne, out float firstNum);
bool isParsedSecond = float.TryParse(numTwo, out float secondNum);

if(!isParsedFirst || !isParsedSecond)
{
    Console.WriteLine("Invalid Numbers!");
}
else
{
    switch (operation)
    {
        case "+":
            result = firstNum + secondNum;
            break;
        case "-":
            result = firstNum - secondNum;  
            break;
        case "*":
            result = firstNum * secondNum;
            break;
        case "/":
            if (secondNum != 0)
            {
                result = firstNum / secondNum; 
            }
            else
            {
                Console.WriteLine("You can not divide by zero!");
            }
            break;
        default:
            Console.WriteLine("Invalid operation!");
            break;
    }
    Console.WriteLine("The result is: "+ result);
}
#endregion
