namespace uke2Dag1;

class Program
{
    static void Main(string[] args)
    {
        // int[] arrayExample = [1, 2, 56, 4, 8, 56, 8, 4, 6];
        // int[] secondArrayExample = new int[10];
        // secondArrayExample[4] = 5;

        // int elementWeWant = arrayExample[4];
        // Console.WriteLine(elementWeWant);


        // List<int> shoppingList = [1, 4, 8, 7, 5, 41, 5, 4, 798, 69];

        // Dictionary<string, bool> checker = new Dictionary<string, bool>()
        // {
        //     //checker["isThisTrue"] = true; 
        //     ["isRunning"] = false,
        //     ["isSitting"] = true
        // };

        Dog Dog = new Dog();
        Dog.Name = "Fido";
        Dog.Age = 5;

        List<string> Types = new List<string>
        {
            "Golden Retriever",
            "Labrador"
        };
        Dog.Pedegree = Types;
        Dog.BetterGreeting();

        Dog Ralph = new Dog();
        Ralph.Name = "Ralph";
        Ralph.Age = 3;

        List<string> Types2 = new List<string>
        {
            "Schauzer",
            "Douberman"
        };
        Ralph.Pedegree = Types2;
        Ralph.BetterGreeting();

    }
}

public class Dog
    {
        public string? Name;

        public int Age;

        public List<string>? Pedegree;

        public void BetterGreeting()
        {
            if (Pedegree is null || Pedegree.Count is 0)
            {
                Console.WriteLine($"Hello this is {Name}. It is {Age} years old. It needs a pedegree, please provide one.");
                return;
            }
            string values;

            if (Pedegree.Count is 1)
            {
                values = Pedegree[0];
            }
            else
            {
                values = string.Join(",", Pedegree.Take(Pedegree.Count - 1)) + " & " + Pedegree.Last();
            }
            Console.WriteLine($"Hello this is {Name}. It is {Age} years old. It is a {values}");
        }
    }
