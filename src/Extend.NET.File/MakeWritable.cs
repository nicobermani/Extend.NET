namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Removes the read-only attribute from the file.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    public static void MakeWritable(this FileInfo file)
    {
        file.IsReadOnly = false;
    }
}