namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the last write time of the file in UTC.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The last write time of the file in UTC.</returns>
    public static DateTime GetLastWriteTimeUtc(this FileInfo file)
    {
        return file.LastWriteTimeUtc;
    }
}