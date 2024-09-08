namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file extension without the leading dot in lowercase.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file extension without the leading dot in lowercase, or an empty string if there's no extension.</returns>
    public static string GetFileExtensionWithoutDotLowerCase(this FileInfo file)
    {
        return file.Extension.TrimStart('.').ToLower();
    }
}