using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the size of the file in bytes.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The size of the file in bytes.</returns>
    public static long GetFileSize(this FileInfo file)
    {
        return file.Length;
    }
}