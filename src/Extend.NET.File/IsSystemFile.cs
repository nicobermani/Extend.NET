using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file is a system file.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file is a system file, false otherwise.</returns>
    public static bool IsSystemFile(this FileInfo file)
    {
        return file.Attributes.HasFlag(FileAttributes.System);
    }
}