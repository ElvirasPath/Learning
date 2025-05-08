namespace mvc_learning.Views;

using System;

public class View
{
    public void ShowImageInfo(ImageMetadata metadata)
    {
        Console.WriteLine("\n🔍 Image Metadata:");
        Console.WriteLine($"📄 File Name:        {metadata.FileName}");
        Console.WriteLine($"📦 File Size:        {metadata.FileSizeInBytes} bytes");
        Console.WriteLine($"📐 Dimensions:       {metadata.Width} x {metadata.Height}");
        Console.WriteLine($"🖼️ Format:           {metadata.Format}");
        Console.WriteLine($"📷 Camera Make:      {metadata.CameraMake ?? "N/A"}");
        Console.WriteLine($"📷 Camera Model:     {metadata.CameraModel ?? "N/A"}");
        Console.WriteLine($"🕒 Date Taken:       {metadata.DateTaken?.ToString("yyyy-MM-dd HH:mm:ss") ?? "N/A"}");
        Console.WriteLine($"🌍 GPS Longitude:    {metadata.GPSLongitude ?? "N/A"}");
        Console.WriteLine($"🌍 GPS Latitude:     {metadata.GPSLatitude ?? "N/A"}");
    }
}
