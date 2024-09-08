namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file has an extension.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file has an extension, false otherwise.</returns>
    public static bool HasExtension(this FileInfo file)
    {
        return !string.IsNullOrEmpty(file.Extension);
    }
}