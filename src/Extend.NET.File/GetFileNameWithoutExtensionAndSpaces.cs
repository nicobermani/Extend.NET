using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file name without extension and spaces.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file name without extension and spaces.</returns>
    public static string GetFileNameWithoutExtensionAndSpaces(this FileInfo file)
    {
        return Path.GetFileNameWithoutExtension(file.Name).Replace(" ", "");
    }
}