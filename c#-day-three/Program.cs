// namespace day3;


using System.IO.Compression;

class Program
{
    static void Main(string[] args)

    {
        IFlyable bird = new Bird();
        IFlyable airplane = new Airplane();
        Superman superman = new Superman();

        bird.Fly();
        airplane.Fly();
        superman.Fly();
        superman.Swim();
    }

    public interface ISwimable
    {
        void Swim();

    }

    //Parent Class
    //Where the interface is defined 

    public interface IFlyable
    {
        void Fly();

    }
    //Child Class
    //Where the interface is implemented 

    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Is it a bird?");
        }
    }
    //Another child class
    public class Airplane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Is it a plane?");
        }
    }
    public class Superman : IFlyable, ISwimable
    {
        public void Fly()
        {
            Console.WriteLine("No, it's Superman");
        }

        public void Swim()
        {
            Console.WriteLine("Oh, and Superman can also swim!");
        }
    }
        }

    //      Animal animal = new Animal { Name = "Cerberus" };
    //     animal.MakeSound();

    //     Dog dog = new Dog { Name = "Brian" };
    //     dog.MakeSound();
    // }
    // //Parent class
    // public class Animal
    // {
    //     public string Name { get; set; }

    //     public void Eat()
    //     {
    //         Console.WriteLine($"{Name} is eating");
    //     }
    //     public virtual void MakeSound()
    //     {
    //         Console.WriteLine("Sqeeek!");
    //     }
    // }
    // //Child class

    // public class Dog : Animal
    // {
    //     public void Bark()
    //     {
    //         Console.WriteLine($"{Name} is barking!");
    //     }
    //     public override void MakeSound()
    //     {
    //         Console.WriteLine("Auyyy!");
    //     }



        // bool gameRunning = true;

        // while (gameRunning)
        // {
        //     Console.WriteLine("I want to play a game");
        //     Console.WriteLine("Choose an option");
        //     Console.WriteLine("1, Ok, let's play?");
        //     Console.WriteLine("2, Naa, I quit");

        //     string? input = Console.ReadLine();

        //     switch (input)
        //     {
        //         case "1":
        //             Console.WriteLine("Are you sure?");
        //             break;

        //         case "2":
        //             Console.WriteLine("Ok, you win...");
        //             gameRunning = false;
        //             break;

        //         default:
        //             Console.WriteLine("That was not one of the option");
        //             break;


        // int [] collection = [1, 2, 3, 4, 5, 6, 7, 8, 9];

        // foreach (var element in collection)
        // {
        //     Console.WriteLine(element);
        // }
        // // for (int i = 0; i <= 5; i++)
        // {
        //     Console.WriteLine(i);
        // }

