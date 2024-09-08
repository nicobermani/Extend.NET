using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file is likely to be a temporary file based on its extension.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file is likely a temporary file, false otherwise.</returns>
    public static bool IsTemporaryFile(this FileInfo file)
    {
        string[] tempExtensions = { ".tmp", ".temp", ".~tmp", ".bak" };
        return tempExtensions.Contains(file.Extension.ToLower());
    }
}