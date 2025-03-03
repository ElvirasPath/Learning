// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");

public static class Robot
{
    public static string sayHi()
    {
        string hi = "hi";
        Console.WriteLine(hi);
        return hi;
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Programm
{
    static void Main()
    {
        Person john = new Person { Name = "John", Age = 30 };
        Person beth = new Person { Name = "Beth", Age = 23 };
        Person alex = new Person { Name = "Alex", Age = 40 };
        Console.WriteLine(john.Name);
    }
}
