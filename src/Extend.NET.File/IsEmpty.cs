namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file is empty (has zero bytes).
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file is empty, false otherwise.</returns>
    public static bool IsEmpty(this FileInfo file)
    {
        return file.Length == 0;
    }
}