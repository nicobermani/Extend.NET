namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file is compressed based on its extension.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file is compressed, false otherwise.</returns>
    public static bool IsCompressed(this FileInfo file)
    {
        string[] compressedExtensions = { ".zip", ".rar", ".7z", ".gz", ".tar", ".bz2" };
        return compressedExtensions.Contains(file.Extension.ToLower());
    }
}