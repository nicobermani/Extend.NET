namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file is a text file based on its extension.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file is a text file, false otherwise.</returns>
    public static bool IsText(this FileInfo file)
    {
        string[] textExtensions = { ".txt", ".csv", ".log", ".xml", ".json", ".html", ".css", ".js" };
        return textExtensions.Contains(file.Extension.ToLower());
    }
}