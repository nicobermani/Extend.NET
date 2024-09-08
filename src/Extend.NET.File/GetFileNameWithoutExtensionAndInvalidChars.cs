using System.Text.RegularExpressions;

namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file name without extension and any invalid characters.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file name without extension and invalid characters.</returns>
    public static string GetFileNameWithoutExtensionAndInvalidChars(this FileInfo file)
    {
        string fileName = Path.GetFileNameWithoutExtension(file.Name);
        string invalidChars = Regex.Escape(new string(Path.GetInvalidFileNameChars()));
        string invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);
        return Regex.Replace(fileName, invalidRegStr, "_");
    }
}