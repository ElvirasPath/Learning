using System.Runtime.InteropServices;

namespace bubble_task;

class Program
{
    static void Main(string[] args)
    {
        int[] myNumbers = { 12, 45, 89, 3, 50 };
        //Console.WriteLine($"Before Swap: {myNumbers}");

        for (int i = 0; i < myNumbers.Length; i++)
        {
            for (int j = 0; j < myNumbers.Length; j++)
            {
                if (myNumbers[i] > myNumbers[j])
                {
                    int temp = myNumbers[i];
                    myNumbers[i] = myNumbers[j];
                    myNumbers[j] = temp;
                }
            }
        }
        foreach (int i in myNumbers)
        {
            Console.WriteLine(i);
        }
        //Console.WriteLine($"After Swap: {myNumbers}");
    }
}