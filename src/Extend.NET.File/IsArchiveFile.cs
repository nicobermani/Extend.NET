using System.IO;
using System.Linq;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file is an archive file based on its extension.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file is an archive file, false otherwise.</returns>
    public static bool IsArchiveFile(this FileInfo file)
    {
        string[] archiveExtensions = { ".zip", ".rar", ".7z", ".tar", ".gz", ".bz2", ".xz" };
        return archiveExtensions.Contains(file.Extension.ToLower());
    }
}