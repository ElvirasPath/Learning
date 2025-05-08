using System;

namespace ImageInfoMVCApp.Views

    public class View
{
    public void ShowImageInfo(ImageMetaData data)
    {
        public string FileName { get; set; }
    public long FileSizeInBytes { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public string Format { get; set; }
    public string? CameraMake { get; set; }
    public string? CameraModel { get; set; }
    public DateTime? DateTaken { get; set; }
    public string? GPSLongitude { get; set; }
    public string? GPSLatitude { get; set; }
}
}
