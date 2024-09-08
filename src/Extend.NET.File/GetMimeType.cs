namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the MIME type of the file based on its extension.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The MIME type of the file, or "application/octet-stream" if unknown.</returns>
    public static string GetMimeType(this FileInfo file)
    {
        var mimeType = "application/octet-stream";
        var ext = file.Extension.ToLower();
        var regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);
        if (regKey != null && regKey.GetValue("Content Type") != null)
            mimeType = regKey.GetValue("Content Type").ToString();
        return mimeType;
    }
}