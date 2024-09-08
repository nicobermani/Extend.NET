using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Sets the file as read-only.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    public static void MakeReadOnly(this FileInfo file)
    {
        file.IsReadOnly = true;
    }
}