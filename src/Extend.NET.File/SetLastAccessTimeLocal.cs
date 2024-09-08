namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Sets the last access time of the file in the local time zone.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <param name="lastAccessTime">The local date and time to set as the last access time.</param>
    public static void SetLastAccessTimeLocal(this FileInfo file, DateTime lastAccessTime)
    {
        file.LastAccessTime = lastAccessTime;
    }
}