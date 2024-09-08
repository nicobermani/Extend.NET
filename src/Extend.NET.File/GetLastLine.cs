using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the last line of a text file.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The last line of the file, or null if the file is empty.</returns>
    public static string GetLastLine(this FileInfo file)
    {
        using (var reader = new StreamReader(file.FullName))
        {
            string lastLine = null;
            string currentLine;
            while ((currentLine = reader.ReadLine()) != null)
            {
                lastLine = currentLine;
            }
            return lastLine;
        }
    }
}