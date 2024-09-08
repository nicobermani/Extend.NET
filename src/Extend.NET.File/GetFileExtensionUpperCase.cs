using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file extension in uppercase, including the dot.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file extension in uppercase, including the dot, or an empty string if there's no extension.</returns>
    public static string GetFileExtensionUpperCase(this FileInfo file)
    {
        return file.Extension.ToUpper();
    }
}