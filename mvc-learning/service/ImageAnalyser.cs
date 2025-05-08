namespace mvc_learning;

using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Metadata.Profiles.Exif;
using SixLabors.ImageSharp.PixelFormats;
using System.Globalization;


public class ImageAnalyser
{
    public ImageMetadata Analyse(string filePath)
    {
        var fileInfo = new FileInfo(filePath);
        using var image = Image.Load<Rgba32>(filePath);

        var metaData = new ImageMetadata
        {
            FileName = fileInfo.Name,
            FileSizeInBytes = fileInfo.Length,
            Width = image.Width,
            Height = image.Height,
            Format = image.Metadata.DecodedImageFormat?.Name ?? "Unknown",
        };
        // Get EXIF data from the image
        var exifProfileValues = image.Metadata.ExifProfile;

        if (exifProfileValues != null)
        {
            // Extract EXIF data from the image metadata with TryGetValue method 
            metaData.CameraMake = exifProfileValues.TryGetValue(ExifTag.Make, out var make) ? make.ToString() : null;
            metaData.CameraModel = exifProfileValues.TryGetValue(ExifTag.Model, out var model) ? model.ToString() : null;

            // Extract date taken from the EXIF data
            // We need to parse it to a DateTime object, but TryParse does not work with this format
            // So we use TryParseExact instead
            // The date is stored in the format "yyyy:MM:dd HH:mm:ss"
            string? dateTime = exifProfileValues.TryGetValue(ExifTag.DateTime, out var dateTaken) ? dateTaken.ToString() : null;
            if (dateTime != null)
            {
                if (DateTime.TryParseExact(dateTime, "yyyy:MM:dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsedDate))
                {
                    metaData.DateTaken = parsedDate;
                }
                else
                {
                    Console.WriteLine($"Failed to parse date: {dateTime}");
                }
            }


            // Extract GPS data from the EXIF data
            // GPS data is stored in the format "degrees, minutes, seconds" in Rational[] format and have 3 values
            // We need to parse it to a string with the format "degrees° minutes' seconds""            
            var gpsLongitude = exifProfileValues.TryGetValue(ExifTag.GPSLongitude, out var longitude) ? longitude : null;
            var gpsLatitude = exifProfileValues.TryGetValue(ExifTag.GPSLatitude, out var latitude) ? latitude : null;

            // foreach does not work with the Rational[] type, so we need to use a for loop instead
            for (int i = 0; i < 2; i++)
            {
                if (gpsLongitude?.Value != null && gpsLatitude?.Value != null && gpsLongitude.Value.Length == 3 && gpsLatitude.Value.Length == 3)
                {
                    // here we using SixLabors.ImageSharp.Rational[]? instead of var to show the type of the variable
                    SixLabors.ImageSharp.Rational[]? longitudeValue = gpsLongitude.Value;
                    // this is the same as above
                    var latitudeValue = gpsLatitude.Value;
                    // Formating the values to a string with the format "degrees° minutes' seconds""
                    metaData.GPSLongitude = $"{longitudeValue[0]}° {longitudeValue[1]}\' {longitudeValue[2]}\"";
                    metaData.GPSLatitude = $"{latitudeValue[0]}° {latitudeValue[1]}\' {latitudeValue[2]}\"";
                }
            }

        }
        ;
        return metaData;
    }
}