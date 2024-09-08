namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file name is too long for the current file system.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file name is too long, false otherwise.</returns>
    public static bool IsFileNameTooLong(this FileInfo file)
    {
        return file.FullName.Length >= 260; // 260 is the maximum path length for Windows
    }
}