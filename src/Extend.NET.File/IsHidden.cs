using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file is hidden.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file is hidden, false otherwise.</returns>
    public static bool IsHidden(this FileInfo file)
    {
        return file.Attributes.HasFlag(FileAttributes.Hidden);
    }
}