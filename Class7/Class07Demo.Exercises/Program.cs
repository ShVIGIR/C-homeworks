// See https://aka.ms/new-console-template for more information

using Class07Demo;
using Class07Demo.Enums;

Console.WriteLine("Hello, World!");

Employee employee = new Employee()
{
    FirstName = "Zlatko",
    LastName = "Zlatev",
    Role = Role.Other
};


Manager manager = new Manager("Elon", "Mask", 200);
manager.PrintInfo();
manager.AddBonus(100);
manager.PrintInfo();

SalesPerson salesperson = new SalesPerson("Radica", "Shvigir");
salesperson.PrintInfo();

Console.WriteLine("--------------------------------Homework-----------------------------------");

#region Homework7 - task 1, 2

Contractor contractorOne = new Contractor()
{
    FirstName = "Viktorija",
    LastName = "Nikolovska",
    WorkHours = 160,
    PayPerHour = 300,
    Role = Role.Other
};
Contractor contractorTwo = new Contractor()
{
    FirstName = "Marija",
    LastName = "Ristevski",
    WorkHours = 120,
    PayPerHour = 300,
    Role = Role.Other
};
Manager managerOne = new Manager("Leona", "Stiveska", 20000);
Manager managerTwo = new Manager("Simeon", "Bikovski", 45000);

SalesPerson salesPers = new SalesPerson("Viktor", "Lordanski");

Employee[] company = new Employee[]
{
    contractorOne,
    contractorTwo,
    managerOne,
    managerTwo,
    salesPers
};

CEO ceoName = new CEO("Ron", "Ronski", 2000)
{
    Shares = 1000,
    Employees = company
};

Console.WriteLine("CEO:");
ceoName.PrintInfo();

ceoName.AddSharesPrice(250);
Console.WriteLine("Salary of CEO is: " + ceoName.GetSalary());

Console.WriteLine("Employees:");
ceoName.PrintEmployees();


#endregion
