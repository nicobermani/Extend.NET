using System.IO;
using System.Linq;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file is an image based on its extension.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file is an image, false otherwise.</returns>
    public static bool IsImage(this FileInfo file)
    {
        string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff" };
        return imageExtensions.Contains(file.Extension.ToLower());
    }
}