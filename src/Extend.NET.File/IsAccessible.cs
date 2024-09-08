using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file is accessible for reading.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file is accessible, false otherwise.</returns>
    public static bool IsAccessible(this FileInfo file)
    {
        try
        {
            using (file.OpenRead())
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