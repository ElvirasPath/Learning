using System;
using System.IO;
using ImageInfoMVCApp.Models;
using ImageInfoMVCApp.Views;

namespace mvc_learning.Controllers;

using System;
using System.IO;

public class ImageController
{
    private readonly ImageAnalyser imageAnalyser = new ImageAnalyser();
    private readonly View view = new View();

    public void AnalyseAndDisplayImageInformation(string? filePath)
    {
        if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
        {
            Console.WriteLine("❌ The file path is invalid or the file does not exist.");
            return;
        }

        var metaData = imageAnalyser.Analyse(filePath);
        view.ShowImageInfo(metaData);
    }
}
