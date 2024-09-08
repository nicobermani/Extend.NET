using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file name without extension in lowercase.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file name without extension in lowercase.</returns>
    public static string GetFileNameWithoutExtensionLowerCase(this FileInfo file)
    {
        return Path.GetFileNameWithoutExtension(file.Name).ToLower();
    }
}