using System.IO;
using Microsoft.Win32;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the MIME type of the file based on its extension.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The MIME type of the file, or "application/octet-stream" if unknown.</returns>
    public static string GetMimeType(this FileInfo file)
    {
        string mimeType = "application/octet-stream";
        string ext = file.Extension.ToLower();
        Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);
        if (regKey != null && regKey.GetValue("Content Type") != null)
            mimeType = regKey.GetValue("Content Type").ToString();
        return mimeType;
    }
}