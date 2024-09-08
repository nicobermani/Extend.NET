namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file is an executable based on its extension.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file is an executable, false otherwise.</returns>
    public static bool IsExecutable(this FileInfo file)
    {
        string[] executableExtensions = { ".exe", ".bat", ".cmd", ".msi", ".sh" };
        return executableExtensions.Contains(file.Extension.ToLower());
    }
}