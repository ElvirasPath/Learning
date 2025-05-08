using System;
using ImageInfoMVCApp.Controllers;
using ImageInfoMVCApp.Models;
using ImageInfoMVCApp.Views;

namespace mvc_learning

    class Program
    {
        static void Main(string[] args)
        {
            ImageController controller = new ImageController();
            Console.WriteLine("Image file path:");

            string? path = Console.ReadLine();

            controller.AnalyseAndDisplayImageInformation(path);

        }
    }