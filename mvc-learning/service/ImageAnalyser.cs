namespace mvc_learning;

using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Metadata.Profiles.Exif;
using System.Globalization;

public class ImageAnalyser
{
    public ImageMetadata Analyse(string filePath)
    {
        // Get basic file info
        var fileInfo = new FileInfo(filePath);

        // Load the image using ImageSharp with pixel format Rgba32
        using var image = Image.Load<Rgba32>(filePath);

        // Create a metadata object and fill in basic info
        var metaData = new ImageMetadata
        {
            FileName = fileInfo.Name,
            FileSizeInBytes = fileInfo.Length,
            Width = image.Width,
            Height = image.Height,
            Format = image.Metadata.DecodedImageFormat?.Name ?? "Unknown"
        };

        // Extract EXIF metadata
        var exifProfileValues = image.Metadata.ExifProfile;

        if (exifProfileValues != null)
        {
            // Get camera make and model
            metaData.CameraMake = exifProfileValues.TryGetValue(ExifTag.Make, out var make) ? make.ToString() : null;
            metaData.CameraModel = exifProfileValues.TryGetValue(ExifTag.Model, out var model) ? model.ToString() : null;

            // Try to get and parse date taken
            if (exifProfileValues.TryGetValue(ExifTag.DateTime, out var dateTaken))
            {
                string? dateTimeString = dateTaken.ToString();
                if (DateTime.TryParseExact(dateTimeString, "yyyy:MM:dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsedDate))
                {
                    metaData.DateTaken = parsedDate;
                }
                else
                {
                    metaData.DateTaken = DateTime.MinValue;
                }
            }

            // Try to get GPS coordinates
            var hasLongitude = exifProfileValues.TryGetValue(ExifTag.GPSLongitude, out var longitude);
            var hasLatitude = exifProfileValues.TryGetValue(ExifTag.GPSLatitude, out var latitude);

            if (hasLongitude && hasLatitude && longitude?.Value?.Length == 3 && latitude?.Value?.Length == 3)
            {
                var lon = longitude.Value!;
                var lat = latitude.Value!;
                metaData.GPSLongitude = $"{lon[0]}° {lon[1]}' {lon[2]}\"";
                metaData.GPSLatitude = $"{lat[0]}° {lat[1]}' {lat[2]}\"";
            }
        }

        return metaData;
    }
}
