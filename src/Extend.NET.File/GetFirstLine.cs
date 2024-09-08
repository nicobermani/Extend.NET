using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the first line of a text file.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The first line of the file, or null if the file is empty.</returns>
    public static string GetFirstLine(this FileInfo file)
    {
        using (var reader = file.OpenText())
        {
            return reader.ReadLine();
        }
    }
}