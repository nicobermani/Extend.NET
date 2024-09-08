namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the size of the file in kilobytes.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The size of the file in kilobytes.</returns>
    public static double GetFileSizeInKilobytes(this FileInfo file)
    {
        return file.Length / 1024.0;
    }
}