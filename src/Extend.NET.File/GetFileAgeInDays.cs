namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the age of the file in days based on its last write time.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The age of the file in days.</returns>
    public static double GetFileAgeInDays(this FileInfo file)
    {
        return (DateTime.Now - file.LastWriteTime).TotalDays;
    }
}