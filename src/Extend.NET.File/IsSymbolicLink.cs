namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file is a symbolic link.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file is a symbolic link, false otherwise.</returns>
    public static bool IsSymbolicLink(this FileInfo file)
    {
        return file.Attributes.HasFlag(FileAttributes.ReparsePoint);
    }
}