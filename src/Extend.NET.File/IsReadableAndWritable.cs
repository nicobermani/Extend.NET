namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file is both readable and writable.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file is both readable and writable, false otherwise.</returns>
    public static bool IsReadableAndWritable(this FileInfo file)
    {
        try
        {
            using (FileStream stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None))
            {
                return true;
            }
        }
        catch (IOException)
        {
            return false;
        }
    }
}