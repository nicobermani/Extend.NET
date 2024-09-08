using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the length of the file extension (including the dot).
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The length of the file extension, or 0 if there's no extension.</returns>
    public static int GetFileExtensionLength(this FileInfo file)
    {
        return file.Extension.Length;
    }
}