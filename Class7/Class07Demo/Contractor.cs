
using Class07Demo.Enums;

namespace Class07Demo
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }
        public override double GetSalary()
        {
           return Salary =  WorkHours * PayPerHour;
        }
        public string  CurrentPosition()
        {
            return Responsible.Department; 
        }
    }
}
