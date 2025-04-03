namespace vehiclesystem;

class Program
{
    static void Main(string[] args)
    {
        Vehicle car = new Car("BMW", 180);
        car.Move();

        Vehicle bike = new Bike("Harley-Davidson", 220);
        bike.Move();

        Boat boat = new Boat("Cruise-boat", 60);
        boat.Move();

        Train train = new Train("Speed-train", 200);
        train.Move();

        
        // List<Vehicle> cars = new List<Vehicle>
        // {
        //     new Vehicle ("Tesla", 200),
        //     new Vehicle ("BMW", 290)
        // };

        // List<Vehicle> bikes = new List<Vehicle>
        // {
        //     new Vehicle 
        // }
    }
}

public class Vehicle //base class
{
    public string? Brand { get; set; } // property
    public int Speed { get; set; }

    public Vehicle(string? brand, int speed) //parameters of constructor to initialize
    {
        Brand = brand;
        Speed = speed;
    }

    public void Display()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
    }

    public virtual void Move() // virtual method to be overridden in child(derived) clases)
    {
        Console.WriteLine("The vehicle is moving.");
    }
}

//These classes inherit from Vehicle base class and override the Move() method.
class Car : Vehicle  // Derived class (Child class)
{
    public Car(string? brand, int speed) : base(brand, speed) {}
    public override void Move()
    {
        Console.WriteLine($"The car {Brand} is moving with speed {Speed} km/h.");
    }

}

class Bike : Vehicle
{
    public Bike(string? brand, int speed) : base(brand, speed) { }
    public override void Move()
    {
        Console.WriteLine($"The bike {Brand} is moving with speed {Speed} km/h.");
    }
}

interface IvehicleService // Interface for vehicle services
{
    void ChargeBattery();
    void FillTires();
}

class ElectricCar : Car, IvehicleService //Implementing the interface in Car
{
    public ElectricCar(string? brand, int speed) : base(brand, speed) { }
    public void ChargeBattery()
    {
        Console.WriteLine($"The {Brand} is charging the battery.");
    }

    public void FillTires()
    {
        Console.WriteLine($"The {Brand} is filling its tires.");
    }
}

//Overload the SpeedUp()
class Speed
{
    public void SpeedUp(int amount)
    {
        Console.WriteLine($"Speed increased by {amount} km/h");
    }
}

class Boat
{
    public string? Brand { get; set; }
    public int Speed { get; set; }

    public Boat(string? brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public void Move()
    {
        Console.WriteLine($"The {Brand} is sailing at {Speed} km/h");
    }
}

class Train
{
    public string? Type { get; set; }
    public int Speed { get; set; }

    public Train(string? type, int speed)
    {
        Type = type;
        Speed = speed;
    }

    public void Move()
    {
        Console.WriteLine($"The {Type} is moving with {Speed} km/h");
    }
}