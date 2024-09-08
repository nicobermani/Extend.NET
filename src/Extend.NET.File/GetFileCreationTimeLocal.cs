namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the creation time of the file in the local time zone.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The creation time of the file in the local time zone.</returns>
    public static DateTime GetFileCreationTimeLocal(this FileInfo file)
    {
        return file.CreationTime;
    }
}