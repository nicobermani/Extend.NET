using System.IO;

public static partial class FileExtensions
{
    /// <summary>
    /// Sets the file as hidden.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    public static void MakeHidden(this FileInfo file)
    {
        file.Attributes |= FileAttributes.Hidden;
    }
}