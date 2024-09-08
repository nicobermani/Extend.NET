using System.Text.RegularExpressions;

namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file name without invalid characters and spaces.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file name with invalid characters and spaces removed.</returns>
    public static string GetFileNameWithoutInvalidCharsAndSpaces(this FileInfo file)
    {
        string invalidChars = Regex.Escape(new string(Path.GetInvalidFileNameChars()));
        string invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);
        string fileNameWithoutInvalidChars = Regex.Replace(file.Name, invalidRegStr, "_");
        return Regex.Replace(fileNameWithoutInvalidChars, @"\s+", "");
    }
}