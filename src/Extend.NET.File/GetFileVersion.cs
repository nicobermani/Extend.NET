using System.Diagnostics;

namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file version information.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file version as a string, or null if version information is not available.</returns>
    public static string GetFileVersion(this FileInfo file)
    {
        FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(file.FullName);
        return versionInfo.FileVersion;
    }
}