// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

partial class Program
{
    static void Main()
    {
        Console.Write("Write your name here: ");
        string? myName = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is your age? ");
        int myAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Person person = new Person(myName, myAge);
        Console.WriteLine($"Hello {person.Name}, you are {person.Age} years old.");
    }
}

class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public Person(string? newName, int newAge) // Constructor
    {
        this.Age = newAge;
        this.Name = newName;
    }
}

