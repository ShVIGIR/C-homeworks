

using Class07Demo.Enums;

namespace Class07Demo
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"First name: {FirstName}, last name: {LastName}, salary: {GetSalary()}.");
        }
        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
