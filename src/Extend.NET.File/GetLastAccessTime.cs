namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the last access time of the file.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The last access time of the file.</returns>
    public static DateTime GetLastAccessTime(this FileInfo file)
    {
        return file.LastAccessTime;
    }
}