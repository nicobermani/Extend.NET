using System;
using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if this file is older than a specified timespan.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <param name="timeSpan">The TimeSpan to compare against.</param>
    /// <returns>True if the file is older than the specified timespan, false otherwise.</returns>
    public static bool IsOlderThan(this FileInfo file, TimeSpan timeSpan)
    {
        return (DateTime.Now - file.LastWriteTime) > timeSpan;
    }
}