namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the creation time of the file.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The creation time of the file.</returns>
    public static DateTime GetCreationTime(this FileInfo file)
    {
        return file.CreationTime;
    }
}