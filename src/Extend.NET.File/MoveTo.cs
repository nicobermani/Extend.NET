namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Moves the file to a new location, overwriting if the destination file already exists.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file to move.</param>
    /// <param name="destFileName">The name of the destination file.</param>
    /// <returns>A new FileInfo object that represents the moved file.</returns>
    public static FileInfo MoveTo(this FileInfo file, string destFileName)
    {
        file.MoveTo(destFileName, true);
        return new FileInfo(destFileName);
    }
}