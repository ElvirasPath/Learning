using System;
using ImageInfoMVCApp.Models;

namespace ImageInfoMVCApp.Views
{
    public class View
    {
        public void ShowImageInfo(ImageMetaData data)
        {
            Console.WriteLine($"File Name: {data.FileName}");
            Console.WriteLine($"File Size: {data.FileSize} bytes");
            Console.WriteLine($"File Type: {data.FileType}");
        }
    }
}