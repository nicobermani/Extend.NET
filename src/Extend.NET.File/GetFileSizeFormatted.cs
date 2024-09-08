namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file size formatted as a human-readable string (e.g., "1.23 MB").
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>A formatted string representing the file size.</returns>
    public static string GetFileSizeFormatted(this FileInfo file)
    {
        long bytes = file.Length;
        string[] suffixes = { "B", "KB", "MB", "GB", "TB", "PB" };
        int counter = 0;
        decimal number = (decimal)bytes;
        while (Math.Round(number / 1024) >= 1)
        {
            number /= 1024;
            counter++;
        }
        return string.Format("{0:n1} {1}", number, suffixes[counter]);
    }
}