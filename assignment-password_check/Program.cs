// class Person
// {
//     string Name { get; set; }
// }

// ArrayList people = new ArrayList();

// people.Add(new Person());
// people.Add(new Person());
// people.Add(4);
// people.Add("string");


// var people = new List<Person>() // Generics
// {
//     new Person(),
//     new Person(),
// }

// var peopleDictionary = new Dictionary<string, Person>();

// people.Add(new Person());

// people.Add(5);

// // base types
// // object, int, string, float/double, bool, char


// string[] strings = new string[] { "Orange", "Banana", "Apple" };

// strings[0]
// strings[1]
// strings[2]


// string fruit = "Orange";
// fruit[6]

// fruit[0] = 'O';

// char[] fruit = new char[] { 'O', 'r', 'a', 'n', 'g', 'e' };

class Program
{

    static void Main(string[] args)
    {

        string? specialChars = "!?.@:";
        bool hasUpper = false, hasLower = false, hasSpecial = false; //Initially, we don’t know if the password has an uppercase letter, lowercase letter, or special character.

        Console.Write("Create your password: ");
        string? newPassword = Console.ReadLine();


        if (newPassword?.Length < 5)
        {
            Console.WriteLine("❌Weak password, please enter at least 5 characters");
            return;
        }


        for (int i = 0; i < newPassword?.Length; i++)

        {
            char character = newPassword[i]; // Get each character at index i 

            if (specialChars.Contains(newPassword[i])) hasSpecial = true;
            if (char.IsLower(character)) hasLower = true;
            if (char.IsUpper(character)) hasUpper = true;

        }

        //Check if all conditions are met 
        if (hasSpecial && hasUpper && hasLower)
        {
            Console.WriteLine("✅ Strong password");
        }
        else
        {
            Console.WriteLine("❌Password must contain at least one uppercase and lower letter, together with at lest one special character");

        }


    }

    // class Car
    // {

    // }

    // class Garage
    // {
    //     List<Car> Cars { get; set; }
    // }


    // Garage[0] 









}