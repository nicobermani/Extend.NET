using System;
using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if this file is newer than another file.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <param name="otherFile">The FileInfo object representing the other file to compare with.</param>
    /// <returns>True if this file is newer, false otherwise.</returns>
    public static bool IsNewerThan(this FileInfo file, FileInfo otherFile)
    {
        return file.LastWriteTime > otherFile.LastWriteTime;
    }
}