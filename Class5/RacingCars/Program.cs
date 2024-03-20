// See https://aka.ms/new-console-template for more information
using RacingCars.Classes;


Console.WriteLine("Raccing Cars App");

#region Code - Racing cars
Car hyundai = new Car("Hyundai", 190);
Car mazda = new Car("Mazda", 210);
Car ferrari = new Car("Ferrari", 290);
Car porsche = new Car("Porsche", 260);

Car[] cars = new Car[]
{
    hyundai, 
    mazda,
    ferrari,
    porsche
};

Driver radica = new Driver("Radica", 0.5);
Driver murat = new Driver("Murat", 1);
Driver simeon = new Driver("Simeon", 0.8);
Driver sara = new Driver("Sara", 0.7);

Driver[] drivers = new Driver[]
{
    radica,
    murat,
    simeon,
    sara
};
static Driver GetDriver(string inputDriver, Driver[] drivers)
{
 foreach(Driver driver in drivers)
    {
      if (driver.Name == inputDriver)
        {
            return driver;
        }
    }
    return null;        
}
static Car GetCar(string inputCar, Car[] cars)
{
    foreach (Car car in cars) {
        if (car.Model == inputCar)
        {
            return car;
        }
    }
    return null;   
}
 static void CarList(Car[] cars )
{
    foreach (Car car in cars)
    {
        Console.WriteLine($"* Car {car.Model.ToUpper()}");
    }
}
static void CarListMinus(Car[] cars, Car inputCarOne)
{
    foreach(Car car in cars)
    {
        if(car != inputCarOne)
        {
           Console.WriteLine($"Car {car.Model.ToUpper()}"); 
        }
    }
}

static void DriverList(Driver[] drivers)
{
    foreach( Driver driver in drivers)
    {
        Console.WriteLine($"Driver {driver.Name.ToUpper()}");
    }
}

static void DriverListMinus(Driver[] drivers, Driver driverOne)
{
    foreach(Driver driver in drivers)
    {
        if (driver != driverOne)
        {
            Console.WriteLine($"Driver {driver.Name.ToUpper()}");
        }
    }
}

static void raceCars(Car carOne, Car carTwo)
{
    if (carOne.Speed > carTwo.Speed)
    {
        Console.WriteLine($"Car No.1, {carOne.Model.ToUpper()}, with driver {carOne.Driver.Name.ToUpper()} is faster.");
    }
    else 
    {
        Console.WriteLine($"Car No.2, {carTwo.Model.ToUpper()}, with driver {carTwo.Driver.Name.ToUpper()} is faster.");
    }
}
while (true)
{
    Console.ReadLine();
    Console.WriteLine("Choose a car no.1: (only car model)");
    CarList(cars);
    string inputCarOne = Console.ReadLine().ToLower();
    if (inputCarOne != "hundai" && inputCarOne != "mazda" && inputCarOne != "ferrari" && inputCarOne != "porsche")
    {
        Console.WriteLine("Invalid car!");
        continue;
    }
    else
    {
        Car carOne = GetCar(inputCarOne, cars);

        Console.WriteLine("Choose a driver no.1: (only diver's name)");
        DriverList(drivers);
        string driverOne = Console.ReadLine().ToLower();
        if (driverOne != "radica" && driverOne != "murat" && driverOne != "simeon" && driverOne != "sara")
        {
            Console.WriteLine("Invalid driver!");
            continue;
        }
        else
        {
            Driver driverFirstCar = GetDriver(driverOne, drivers);
            carOne.Driver = driverFirstCar;
            while (true) { 
            Console.WriteLine("Choose a car no.2: (only car model)");
            CarListMinus(cars, carOne);
            string inputCarTwo = Console.ReadLine().ToLower();
                if (inputCarTwo != "hundai" && inputCarTwo != "mazda" && inputCarTwo != "ferrari" && inputCarTwo != "porsche")
                {
                    Console.WriteLine("Invalid car!");
                    continue;
                }
                else if (inputCarTwo == inputCarOne)
                {
                    Console.WriteLine("The car is already taken. Choose another car.");
                    continue;
                }
                else
                {
                    Car carTwo = GetCar(inputCarTwo, cars);
                    Console.WriteLine("Choose a driver no.2:");
                    DriverListMinus(drivers, driverFirstCar);
                    string driverTwo = Console.ReadLine().ToLower();
                    if (driverTwo != "radica" && driverTwo != "murat" && driverTwo != "simeon" && driverTwo != "sara")
                    {
                        Console.WriteLine("Invalid driver!");
                    }
                    else if(driverTwo == driverOne)
                    {
                        Console.WriteLine("The driver is already taken. Choose another driver.");
                        continue;
                    }
                    else
                    {
                        Driver driverSecondCar = GetDriver(driverTwo, drivers);
                        carTwo.Driver = driverSecondCar;


                        raceCars(carOne, carTwo);
                        break;
                    }
                }
            }
        }
    }
}


#endregion
Console.ReadLine();