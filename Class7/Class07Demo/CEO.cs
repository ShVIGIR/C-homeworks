using Class07Demo.Enums;

namespace Class07Demo
{
    public class CEO : Employee
    {
        public Employee[] Employees {  get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }
        public CEO (string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }
        public void AddSharesPrice(double sharesPrice)
        {
            SharesPrice = sharesPrice;
        }
        public void PrintEmployees()
        {
            foreach (Employee employee in Employees)
            {
                
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }
        public override double GetSalary()
        {
            return Salary + Shares + SharesPrice;
        }
    }
}
