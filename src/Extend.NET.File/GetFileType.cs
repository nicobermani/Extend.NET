using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file type based on its extension.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>A string representing the file type.</returns>
    public static string GetFileType(this FileInfo file)
    {
        switch (file.Extension.ToLower())
        {
            case ".txt":
            case ".log":
                return "Text";
            case ".jpg":
            case ".jpeg":
            case ".png":
            case ".gif":
                return "Image";
            case ".mp3":
            case ".wav":
            case ".flac":
                return "Audio";
            case ".mp4":
            case ".avi":
            case ".mov":
                return "Video";
            case ".doc":
            case ".docx":
                return "Word Document";
            case ".xls":
            case ".xlsx":
                return "Excel Spreadsheet";
            case ".pdf":
                return "PDF";
            default:
                return "Unknown";
        }
    }
}