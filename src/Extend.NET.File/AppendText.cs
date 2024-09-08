namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Appends text to the file.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <param name="text">The text to append.</param>
    public static void AppendText(this FileInfo file, string text)
    {
        System.IO.File.AppendAllText(file.FullName, text);
    }
}