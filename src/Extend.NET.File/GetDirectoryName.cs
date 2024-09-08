using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the directory name of the file.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The directory name of the file.</returns>
    public static string GetDirectoryName(this FileInfo file)
    {
        return file.DirectoryName;
    }
}