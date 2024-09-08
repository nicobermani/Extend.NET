using System.Text.RegularExpressions;

namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file name without invalid characters and extension.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file name without invalid characters and extension.</returns>
    public static string GetFileNameWithoutInvalidCharsAndExtension(this FileInfo file)
    {
        var fileName = Path.GetFileNameWithoutExtension(file.Name);
        var invalidChars = Regex.Escape(new string(Path.GetInvalidFileNameChars()));
        var invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);
        return Regex.Replace(fileName, invalidRegStr, "_");
    }
}