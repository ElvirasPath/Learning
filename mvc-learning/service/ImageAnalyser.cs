using System;
using System.IO;
using System.Linq;
using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using MetadataExtractor.Formats.Jpeg;
using SixLabors.ImageSharp;                  // ImageSharp
using SixLabors.ImageSharp.Formats;          // For image format
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Metadata;
using System.Globalization;

public class ImageAnalyser
{
    public ImageMetadata Analyse(string? filePath)
    {
        var fileInfo = new FileInfo(filePath!);

        using var image = Image.Load<Rgba32>(filePath!); // Load image with ImageSharp

        var metaData = new ImageMetadata
        {
            FileName = fileInfo.Name,
            FileSizeInBytes = fileInfo.Length,
            Width = image.Width,
            Height = image.Height,
            Format = image.Metadata.DecodedImageFormat?.Name ?? "Unknown"
        };

        var directories = Image.Load(filePath!).Metadata;

        var subIfdDirectory = directories.GetJpegMetadata();
        var ifd0 = directories.OfType<ExifIfd0Directory>().FirstOrDefault();
        var gps = directories.OfType<GpsDirectory>().FirstOrDefault();

        metaData.CameraMake = ifd0?.GetDescription(ExifDirectoryBase.TagMake);
        metaData.CameraModel = ifd0?.GetDescription(ExifDirectoryBase.TagModel);

        var dateTimeString = subIfdDirectory?.GetDescription(ExifDirectoryBase.TagDateTime);

        if (DateTime.TryParse(dateTimeString, CultureInfo.InvariantCulture, out DateTime parsedDate))
        {
            metaData.DateTaken = parsedDate.ToUniversalTime();
        }
        else
        {
            metaData.DateTaken = DateTime.MinValue;
        }

        if (gps?.GetGeoLocation() != null)
        {
            var location = gps.GetGeoLocation();
            metaData.GPSLatitude = location!.Latitude.ToString();
            metaData.GPSLongitude = location.Longitude.ToString();
        }

        return metaData;
    }
}
