using MetadataExtractor; // (❗Not used here anymore — can be removed)
using MetadataExtractor.Formats.Exif; // (❗Also unused in this version)

using SixLabors.ImageSharp; // Main library to load and work with images
using SixLabors.ImageSharp.Processing; // Needed for advanced image editing (not directly used here)
using SixLabors.ImageSharp.Metadata.Profiles.Exif; // To access EXIF metadata like camera info, date taken
using SixLabors.ImageSharp.PixelFormats; // Used to specify how image pixels are represented (Rgba32 = red, green, blue, alpha)
using System.Globalization; // Allows us to control date formats (important for parsing EXIF date)


public class ImageAnalyser
{
    public ImageMetadata Analyse(string filePath)
    {
        var fileInfo = new FileInfo(filePath);

        // Load the image with RGBA pixel format
        using var image = Image.Load<Rgba32>(filePath);

        // Basic file and image information
        var metaData = new ImageMetadata
        {
            FileName = fileInfo.Name,
            FileSizeInBytes = fileInfo.Length,
            Width = image.Width,
            Height = image.Height,
            Format = image.Metadata.DecodedImageFormat?.Name ?? "Unknown"
        };

        // Access EXIF metadata if it exists
        var exifProfile = image.Metadata.ExifProfile;

        if (exifProfile != null)
        {
            // Camera info
            metaData.CameraMake = exifProfile.TryGetValue(ExifTag.Make, out var make) ? make.ToString() : null;
            metaData.CameraModel = exifProfile.TryGetValue(ExifTag.Model, out var model) ? model.ToString() : null;

            // Date taken
            if (exifProfile.TryGetValue(ExifTag.DateTime, out var dateTag))
            {
                string dateString = dateTag.ToString();
                if (DateTime.TryParseExact(dateString, "yyyy:MM:dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsedDate))
                {
                    metaData.DateTaken = parsedDate;
                }
                else
                {
                    metaData.DateTaken = DateTime.MinValue;
                }
            }

            // GPS coordinates
            if (exifProfile.TryGetValue(ExifTag.GPSLongitude, out var longTag) &&
                exifProfile.TryGetValue(ExifTag.GPSLatitude, out var latTag) &&
                longTag.Value is SixLabors.ImageSharp.Rational[] longitude &&
                latTag.Value is SixLabors.ImageSharp.Rational[] latitude &&
                longitude.Length == 3 && latitude.Length == 3)
            {
                metaData.GPSLongitude = $"{longitude[0]}° {longitude[1]}' {longitude[2]}\"";
                metaData.GPSLatitude = $"{latitude[0]}° {latitude[1]}' {latitude[2]}\"";
            }
        }

        return metaData;
    }
}