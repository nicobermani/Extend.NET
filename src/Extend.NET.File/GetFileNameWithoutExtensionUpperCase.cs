namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file name without extension in uppercase.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file name without extension in uppercase.</returns>
    public static string GetFileNameWithoutExtensionUpperCase(this FileInfo file)
    {
        return Path.GetFileNameWithoutExtension(file.Name).ToUpper();
    }
}