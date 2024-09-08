using System;
using System.IO;
using System.Security.Cryptography;

public static partial class FileExtensions
{
    /// <summary>
    /// Calculates the MD5 hash of the file.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The MD5 hash of the file as a hexadecimal string.</returns>
    public static string GetMD5Hash(this FileInfo file)
    {
        using (var md5 = MD5.Create())
        using (var stream = file.OpenRead())
        {
            byte[] hash = md5.ComputeHash(stream);
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }
    }
}