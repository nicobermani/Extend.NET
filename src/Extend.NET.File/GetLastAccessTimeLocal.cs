using System;
using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the last access time of the file in the local time zone.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The last access time of the file in the local time zone.</returns>
    public static DateTime GetLastAccessTimeLocal(this FileInfo file)
    {
        return file.LastAccessTime;
    }
}