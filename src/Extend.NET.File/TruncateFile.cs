namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Truncates the file to a specified length.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <param name="length">The length to truncate the file to.</param>
    public static void TruncateFile(this FileInfo file, long length)
    {
        using (FileStream stream = file.Open(FileMode.Open, FileAccess.Write))
        {
            stream.SetLength(length);
        }
    }
}