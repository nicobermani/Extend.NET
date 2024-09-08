using System.IO;
using System.Text.RegularExpressions;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file name without numbers and extension.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file name without numbers and extension.</returns>
    public static string GetFileNameWithoutNumbers(this FileInfo file)
    {
        string fileName = Path.GetFileNameWithoutExtension(file.Name);
        return Regex.Replace(fileName, @"\d", "");
    }
}