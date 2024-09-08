using System;
using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file name with a timestamp appended.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file name with a timestamp appended.</returns>
    public static string GetFileNameWithTimestamp(this FileInfo file)
    {
        string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
        return $"{Path.GetFileNameWithoutExtension(file.Name)}_{timestamp}{file.Extension}";
    }
}