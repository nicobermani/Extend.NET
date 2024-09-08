namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Sets the creation time of the file in UTC.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <param name="creationTimeUtc">The UTC date and time to set as the creation time.</param>
    public static void SetCreationTimeUtc(this FileInfo file, DateTime creationTimeUtc)
    {
        file.CreationTimeUtc = creationTimeUtc;
    }
}