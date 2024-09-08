using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the target of a symbolic link.
    /// </summary>
    /// <param name="file">The FileInfo object representing the symbolic link.</param>
    /// <returns>The target path of the symbolic link, or null if the file is not a symbolic link.</returns>
    public static string GetSymbolicLinkTarget(this FileInfo file)
    {
        if (!file.IsSymbolicLink())
        {
            return null;
        }

        return file.ResolveLinkTarget(true)?.FullName;
    }
}