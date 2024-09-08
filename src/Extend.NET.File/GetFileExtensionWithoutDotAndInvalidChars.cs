using System.Text.RegularExpressions;

namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file extension without the leading dot and any invalid characters.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file extension without the leading dot and invalid characters, or an empty string if there's no extension.</returns>
    public static string GetFileExtensionWithoutDotAndInvalidChars(this FileInfo file)
    {
        var extension = file.Extension.TrimStart('.');
        var invalidChars = Regex.Escape(new string(Path.GetInvalidFileNameChars()));
        return Regex.Replace(extension, $"[{invalidChars}]", "");
    }
}