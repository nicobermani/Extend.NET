namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Removes the hidden attribute from the file.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    public static void MakeVisible(this FileInfo file)
    {
        file.Attributes &= ~FileAttributes.Hidden;
    }
}