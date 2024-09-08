namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file name (without extension) is the same as its extension.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file name is the same as its extension, false otherwise.</returns>
    public static bool IsFileNameSameAsExtension(this FileInfo file)
    {
        var nameWithoutExtension = Path.GetFileNameWithoutExtension(file.Name);
        var extensionWithoutDot = file.Extension.TrimStart('.');
        return string.Equals(nameWithoutExtension, extensionWithoutDot, StringComparison.OrdinalIgnoreCase);
    }
}