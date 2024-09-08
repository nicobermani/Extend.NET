using System.IO;
using System.Text.RegularExpressions;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file extension without the leading dot and any invalid characters.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file extension without the leading dot and invalid characters, or an empty string if there's no extension.</returns>
    public static string GetFileExtensionWithoutDotAndInvalidChars(this FileInfo file)
    {
        string extension = file.Extension.TrimStart('.');
        string invalidChars = Regex.Escape(new string(Path.GetInvalidFileNameChars()));
        return Regex.Replace(extension, $"[{invalidChars}]", "");
    }
}