using System.Text.RegularExpressions;

namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file name without numbers and extension.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file name without numbers and extension.</returns>
    public static string GetFileNameWithoutNumbers(this FileInfo file)
    {
        var fileName = Path.GetFileNameWithoutExtension(file.Name);
        return Regex.Replace(fileName, @"\d", "");
    }
}