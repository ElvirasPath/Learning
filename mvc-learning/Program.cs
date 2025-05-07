using System;
using ImageInfoMVCApp.Controllers;
using ImageInfoMVCApp.Models;
using ImageInfoMVCApp.Views;

namespace mvc_learning
{
    class Program
    {
        static void Main()
        {
            var analyser = new ImageAnalyser();
            var view = new View();
            var controller = new ImageController(analyser, view);

            Console.Write("Enter image file path: ");
            var path = Console.ReadLine();

            controller.AnalyseAndShow(path ?? "");
        }
    }
}