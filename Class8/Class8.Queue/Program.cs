using System.ComponentModel.Design;
using System.Xml;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Task 1");
Console.ResetColor();

#region Task 1
//*give the user an option to input numbers
//* after inputing each number ask them if they want to input another with a y/n question
//* store all numbers in a queue
//* when the user is done adding numbers print the number in the order that the user entered them from the queue
#endregion
#region Task 1 - Code

static void PrintNumbers(Queue<int>queue)
{
    foreach (var num in queue)
    {
        Console.Write(num + " ");
    }
}

bool again = true;
Queue<int> queue = new Queue<int>();


Console.WriteLine("Input number: ");
while (again)
{
    string inputNumber = Console.ReadLine();
    bool isParsed = int.TryParse(inputNumber, out int input);

    if (!isParsed)
    {
        Console.WriteLine("Enter valid number!");
    }
    else
    {
        {
            queue.Enqueue(input);
           
            while (true)
            {
                Console.WriteLine("Do you want to add new number? (Enter: Y/N)");
                string inputChar = Console.ReadLine().ToLower();
                if (inputChar != "Y".ToLower() && inputChar != "N".ToLower())
                {
                    Console.WriteLine("Enter valid input.");
                    continue;
                }

                if (inputChar == "N".ToLower())
                {
                    PrintNumbers(queue);
                    again = false;
                    break;
                  
                }
         
                Console.WriteLine("Enter number: ");
                break;
            }
            continue;

        }
    }
}
#endregion
