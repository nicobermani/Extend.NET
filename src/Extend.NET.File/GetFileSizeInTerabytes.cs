using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the size of the file in terabytes.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The size of the file in terabytes.</returns>
    public static double GetFileSizeInTerabytes(this FileInfo file)
    {
        return file.Length / (1024.0 * 1024.0 * 1024.0 * 1024.0);
    }
}