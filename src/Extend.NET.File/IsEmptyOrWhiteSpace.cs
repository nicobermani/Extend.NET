namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file is empty or contains only whitespace characters.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file is empty or contains only whitespace, false otherwise.</returns>
    public static bool IsEmptyOrWhiteSpace(this FileInfo file)
    {
        using (var stream = file.OpenText())
        {
            string content = stream.ReadToEnd();
            return string.IsNullOrWhiteSpace(content);
        }
    }
}