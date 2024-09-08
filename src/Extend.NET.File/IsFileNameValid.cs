using System.IO;
using System.Linq;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file name is valid (doesn't contain invalid characters).
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file name is valid, false otherwise.</returns>
    public static bool IsFileNameValid(this FileInfo file)
    {
        return !file.Name.Any(c => Path.GetInvalidFileNameChars().Contains(c));
    }
}