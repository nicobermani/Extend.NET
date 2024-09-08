using System;
using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the last write time of the file in the local time zone.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The last write time of the file in the local time zone.</returns>
    public static DateTime GetLastWriteTimeLocal(this FileInfo file)
    {
        return file.LastWriteTime;
    }
}