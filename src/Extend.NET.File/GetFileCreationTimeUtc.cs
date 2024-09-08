namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the creation time of the file in UTC.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The creation time of the file in UTC.</returns>
    public static DateTime GetFileCreationTimeUtc(this FileInfo file)
    {
        return file.CreationTimeUtc;
    }
}