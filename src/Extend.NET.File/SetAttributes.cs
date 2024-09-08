using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Sets the attributes of the file.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <param name="attributes">The FileAttributes to set.</param>
    public static void SetAttributes(this FileInfo file, FileAttributes attributes)
    {
        file.Attributes = attributes;
    }
}