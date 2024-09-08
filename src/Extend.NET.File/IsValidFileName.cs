namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the given string is a valid file name.
    /// </summary>
    /// <param name="fileName">The file name to check.</param>
    /// <returns>True if the file name is valid, false otherwise.</returns>
    public static bool IsValidFileName(this string fileName)
    {
        char[] invalidChars = Path.GetInvalidFileNameChars();
        return !string.IsNullOrEmpty(fileName) && 
               fileName.IndexOfAny(invalidChars) == -1 && 
               !fileName.Any(ch => ch < 32);
    }
}