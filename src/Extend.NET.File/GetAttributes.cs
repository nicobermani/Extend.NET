namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the attributes of the file.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The FileAttributes of the file.</returns>
    public static FileAttributes GetAttributes(this FileInfo file)
    {
        return file.Attributes;
    }
}