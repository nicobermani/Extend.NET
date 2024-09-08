using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file size is within a specified range.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <param name="minSizeBytes">The minimum size in bytes.</param>
    /// <param name="maxSizeBytes">The maximum size in bytes.</param>
    /// <returns>True if the file size is within the specified range, false otherwise.</returns>
    public static bool IsWithinSizeRange(this FileInfo file, long minSizeBytes, long maxSizeBytes)
    {
        return file.Length >= minSizeBytes && file.Length <= maxSizeBytes;
    }
}