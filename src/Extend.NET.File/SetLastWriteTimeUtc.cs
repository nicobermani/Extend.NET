namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Sets the last write time of the file in UTC.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <param name="lastWriteTimeUtc">The UTC date and time to set.</param>
    public static void SetLastWriteTimeUtc(this FileInfo file, DateTime lastWriteTimeUtc)
    {
        file.LastWriteTimeUtc = lastWriteTimeUtc;
    }
}