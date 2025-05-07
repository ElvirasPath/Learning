using System.IO;

namespace mvc_learning.Models
{
    public class ImageAnalyser
    {
        public ImageMetaData Analyse(string filePath)
        {
            var fileInfo = new FileInfo(filePath);
            return new ImageMetaData
            {
                FileName = fileInfo.Name,
                FileSize = fileInfo.Length,
                FileType = fileInfo.Extension
            };
        }
    }
}