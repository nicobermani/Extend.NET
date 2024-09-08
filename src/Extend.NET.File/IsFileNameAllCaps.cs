namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file name (without extension) is all uppercase.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file name is all uppercase, false otherwise.</returns>
    public static bool IsFileNameAllCaps(this FileInfo file)
    {
        string fileName = Path.GetFileNameWithoutExtension(file.Name);
        return fileName.All(char.IsUpper);
    }
}