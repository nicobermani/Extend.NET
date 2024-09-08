using System.Text.RegularExpressions;

namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file name without invalid characters and spaces, converted to lowercase.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file name without invalid characters and spaces, in lowercase.</returns>
    public static string GetFileNameWithoutInvalidCharsAndSpacesLowerCase(this FileInfo file)
    {
        string invalidChars = Regex.Escape(new string(Path.GetInvalidFileNameChars()));
        string invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);
        string fileNameWithoutInvalidChars = Regex.Replace(file.Name, invalidRegStr, "_");
        string fileNameWithoutSpaces = Regex.Replace(fileNameWithoutInvalidChars, @"\s+", "");
        return fileNameWithoutSpaces.ToLower();
    }
}