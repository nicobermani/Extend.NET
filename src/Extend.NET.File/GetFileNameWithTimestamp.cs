namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file name with a timestamp appended.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The file name with a timestamp appended.</returns>
    public static string GetFileNameWithTimestamp(this FileInfo file)
    {
        var timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
        return $"{Path.GetFileNameWithoutExtension(file.Name)}_{timestamp}{file.Extension}";
    }
}