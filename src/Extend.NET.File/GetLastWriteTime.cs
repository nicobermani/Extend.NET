namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the last write time of the file.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The last write time of the file.</returns>
    public static DateTime GetLastWriteTime(this FileInfo file)
    {
        return file.LastWriteTime;
    }
}