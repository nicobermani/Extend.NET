namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file extension with the leading dot.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file extension with the leading dot, or an empty string if there's no extension.</returns>
    public static string GetFileExtensionWithDot(this FileInfo file)
    {
        return file.Extension;
    }
}