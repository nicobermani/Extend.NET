using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file extension without the leading dot.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file extension without the leading dot, or an empty string if there's no extension.</returns>
    public static string GetFileExtensionWithoutDot(this FileInfo file)
    {
        return file.Extension.TrimStart('.');
    }
}