

using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace RacingCars.Classes
{
    public class Car
    {
        public string Model {  get; set; }
        public double Speed { get; set; }
        public Driver Driver { get; set; }
        public Car(string model, double speed)
        {
            Model = model.ToLower();
            Speed = speed;

        }
        public double CalculateSpeed(Driver driver)
        {
            return driver.Skill * Speed;
        }
        public string GetDriversName(string driverOne, string driverTwo)
        {
            return Driver.Name;
        }
       
    }
}
