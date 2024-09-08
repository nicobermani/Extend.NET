namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Renames the file.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file to rename.</param>
    /// <param name="newName">The new name for the file.</param>
    /// <returns>A new FileInfo object that represents the renamed file.</returns>
    public static FileInfo Rename(this FileInfo file, string newName)
    {
        string newPath = Path.Combine(file.DirectoryName, newName);
        file.MoveTo(newPath);
        return new FileInfo(newPath);
    }
}