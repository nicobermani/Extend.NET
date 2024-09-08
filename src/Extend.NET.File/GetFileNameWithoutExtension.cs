using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file name without the extension.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file name without the extension.</returns>
    public static string GetFileNameWithoutExtension(this FileInfo file)
    {
        return Path.GetFileNameWithoutExtension(file.Name);
    }
}