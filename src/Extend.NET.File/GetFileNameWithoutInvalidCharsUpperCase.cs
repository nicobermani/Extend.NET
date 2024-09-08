using System.Text.RegularExpressions;

namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file name without invalid characters in uppercase.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file name without invalid characters in uppercase.</returns>
    public static string GetFileNameWithoutInvalidCharsUpperCase(this FileInfo file)
    {
        string invalidChars = Regex.Escape(new string(Path.GetInvalidFileNameChars()));
        string invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);
        return Regex.Replace(file.Name, invalidRegStr, "_").ToUpper();
    }
}