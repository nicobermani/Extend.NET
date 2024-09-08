using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the relative path of this file to a specified directory.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <param name="directory">The directory to get the relative path from.</param>
    /// <returns>The relative path of the file.</returns>
    public static string GetRelativePath(this FileInfo file, DirectoryInfo directory)
    {
        return Path.GetRelativePath(directory.FullName, file.FullName);
    }
}