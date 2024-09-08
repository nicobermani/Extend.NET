using System;
using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Sets the creation time of the file in the local time zone.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <param name="creationTime">The local date and time to set as the creation time.</param>
    public static void SetCreationTimeLocal(this FileInfo file, DateTime creationTime)
    {
        file.CreationTime = creationTime;
    }
}