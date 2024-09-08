namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the last access time of the file in UTC.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The last access time of the file in UTC.</returns>
    public static DateTime GetLastAccessTimeUtc(this FileInfo file)
    {
        return file.LastAccessTimeUtc;
    }
}