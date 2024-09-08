namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Copies the file to a new location, overwriting if the destination file already exists.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file to copy.</param>
    /// <param name="destFileName">The name of the destination file.</param>
    /// <returns>A new FileInfo object that represents the copy of the file.</returns>
    public static FileInfo CopyTo(this FileInfo file, string destFileName)
    {
        return file.CopyTo(destFileName, true);
    }
}