namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file is read-only.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file is read-only, false otherwise.</returns>
    public static bool IsReadOnly(this FileInfo file)
    {
        return file.IsReadOnly;
    }
}