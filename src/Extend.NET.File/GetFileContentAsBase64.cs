using System;
using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the content of the file as a Base64 encoded string.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file content as a Base64 encoded string.</returns>
    public static string GetFileContentAsBase64(this FileInfo file)
    {
        byte[] fileBytes = File.ReadAllBytes(file.FullName);
        return Convert.ToBase64String(fileBytes);
    }
}