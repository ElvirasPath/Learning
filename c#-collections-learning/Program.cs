class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>
        {
            new Animal("Max", 5, "Labrador"),
            new Animal("Cookie", 10, "British Straight"),
            new Animal("Archie", 3, "Kakadu")
        };

        do
        {
            string? userInput = Console.ReadLine();
            if (userInput is "exit shop")
            {
                Console.WriteLine("Have a great day! See you soon:)");
                break;
            }
            if (userInput is "show animals")
            {
                foreach (Animal animal in animals)
                {
                    Console.WriteLine();
                    Console.WriteLine($"This animal name is {animal.Name}.");
                    Console.WriteLine($"This animal age is {animal.Age}.");
                    Console.WriteLine($"This animal breed is {animal.Breed}.");
                    Console.WriteLine();
                }
            }
            if (userInput is "pet animal")
            {
                string names = string.Empty;
                foreach (Animal animal in animals)
                {
                    if (animal.Name != null)
                    {
                        Console.Write($"{animal.Name} ");
                        names += animal.Name;
                    }
                }

                Console.WriteLine();
                Console.Write("Choose an animal: ");
                userInput = Console.ReadLine();

                if (userInput is null)
                {
                    Console.WriteLine("Wrong name");
                    continue;
                }
                if (names.Contains(userInput))
                {
                    Console.WriteLine();
                    Console.WriteLine($"{userInput} is happy");
                }
            }
        } while (true);
    }
}

public class Animal
{
    public string? Name { get; set; } //property

    public int Age { get; set; }

    public string? Breed { get; set; }

    public Animal(string? name, int age, string? breed) //parameters
    {
        Name = name;
        Age = age;
        Breed = breed;
    }
}
