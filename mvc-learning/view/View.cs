public class View
{
    public void ShowImageInfo(ImageMetadata metaData)
    {
        Console.WriteLine("Image file information:");
        Console.WriteLine($"Filename: {metaData.FileName}");
        Console.WriteLine($"Size: {metaData.FileSizeInBytes / 1024.0:F2} KB");
        Console.WriteLine($"Resolution: {metaData.Width} x {metaData.Height}");
        Console.WriteLine($"Format: {metaData.Format}");

        Console.WriteLine($"Camera Make: {metaData.CameraMake}");
        Console.WriteLine($"Camera Model: {metaData.CameraModel}");
        Console.WriteLine($"DateTaken: {metaData.DateTaken: dd/MMMM/yyyy}");
        Console.WriteLine($"GPSLatitude: {metaData.GPSLatitude}");
        Console.WriteLine($"GPSLongitude: {metaData.GPSLongitude}");
    }
}