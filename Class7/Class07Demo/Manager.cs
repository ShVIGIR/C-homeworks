
using Class07Demo.Enums;

namespace Class07Demo
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }
        public string Department { get; set; }
        public Manager()
        {

        }
        public Manager( string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Bonus = 0;
            Role = Role.Manager;
        }
        public void AddBonus(double bonus)
        {
            Bonus += bonus;
        }
        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    
    }
}
