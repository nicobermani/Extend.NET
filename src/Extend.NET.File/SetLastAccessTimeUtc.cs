namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Sets the last access time of the file in UTC.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <param name="lastAccessTimeUtc">The UTC date and time to set as the last access time.</param>
    public static void SetLastAccessTimeUtc(this FileInfo file, DateTime lastAccessTimeUtc)
    {
        file.LastAccessTimeUtc = lastAccessTimeUtc;
    }
}