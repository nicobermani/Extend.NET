using System.IO;
using System.Security.Cryptography;

public static partial class FileExtensions
{
    /// <summary>
    /// Encrypts the file using Windows Encrypting File System (EFS).
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    public static void Encrypt(this FileInfo file)
    {
        file.Encrypt();
    }
}