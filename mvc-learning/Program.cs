using System;
using ImageInfoMVCApp.Controllers;
using ImageInfoMVCApp.Models;
using ImageInfoMVCApp.Views;

namespace mvc_learning;

using System;

class Program
{
    static void Main(string[] args)
    {
        var controller = new ImageController();

        Console.WriteLine("📸 Enter the full image file path:");
        var path = Console.ReadLine();

        controller.AnalyseAndDisplayImageInformation(path);
    }
}
