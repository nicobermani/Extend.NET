namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file extension without the leading dot in uppercase.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file extension without the leading dot in uppercase, or an empty string if there's no extension.</returns>
    public static string GetFileExtensionWithoutDotUpperCase(this FileInfo file)
    {
        return file.Extension.TrimStart('.').ToUpper();
    }
}