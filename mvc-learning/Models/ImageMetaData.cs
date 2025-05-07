namespace mvc_learning.Models
{
    public class ImageMetaData
    {
        public string FileName { get; set; } = string.Empty;
        public long FileSize { get; set; }
        public string FileType { get; set; } = string.Empty;
    }
}