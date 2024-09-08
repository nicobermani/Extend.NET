using System.Text.RegularExpressions;

namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file name without consecutive spaces.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file name with consecutive spaces reduced to a single space.</returns>
    public static string GetFileNameWithoutConsecutiveSpaces(this FileInfo file)
    {
        return Regex.Replace(file.Name, @"\s+", " ");
    }
}