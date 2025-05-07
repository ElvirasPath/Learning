using System;
using System.IO;
using ImageInfoMVCApp.Models;
using ImageInfoMVCApp.Views;

namespace mvc_learning.Controllers
{
    public class ImageController
    {
        private readonly ImageAnalyser analyser;
        private readonly View view;

        public ImageController(ImageAnalyser analyser, View view)
        {
            this.analyser = analyser;
            this.view = view;
        }

        public void AnalyseAndShow(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            var data = analyser.Analyse(filePath);
            view.ShowImageInfo(data);
        }
    }
}