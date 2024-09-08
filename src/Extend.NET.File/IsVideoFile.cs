using System.IO;
using System.Linq;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file is a video file based on its extension.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file is a video file, false otherwise.</returns>
    public static bool IsVideoFile(this FileInfo file)
    {
        string[] videoExtensions = { ".mp4", ".avi", ".mov", ".wmv", ".flv", ".mkv", ".webm" };
        return videoExtensions.Contains(file.Extension.ToLower());
    }
}