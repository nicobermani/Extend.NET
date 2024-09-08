using System;
using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Sets the last write time of the file in the local time zone.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <param name="lastWriteTime">The local date and time to set as the last write time.</param>
    public static void SetLastWriteTimeLocal(this FileInfo file, DateTime lastWriteTime)
    {
        file.LastWriteTime = lastWriteTime;
    }
}