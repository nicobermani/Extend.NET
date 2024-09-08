namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Counts the number of lines in a text file.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The number of lines in the file.</returns>
    public static int CountLines(this FileInfo file)
    {
        var lineCount = 0;
        using (var reader = file.OpenText())
        {
            while (reader.ReadLine() != null)
            {
                lineCount++;
            }
        }
        return lineCount;
    }
}