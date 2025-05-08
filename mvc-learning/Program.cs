namespace mvc_learning;

using System;

class Program
{
    static void Main(string[] args)
    {
        var controller = new ImageController();

        Console.WriteLine("Image file path:");
        var path = Console.ReadLine();

        controller.AnalyseAndDisplayImageInformation(path);
    }
}
