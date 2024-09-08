namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Decrypts the file that was encrypted using Windows Encrypting File System (EFS).
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    public static void Decrypt(this FileInfo file)
    {
        file.Decrypt();
    }
}