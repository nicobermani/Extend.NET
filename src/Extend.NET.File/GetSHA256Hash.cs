using System.Security.Cryptography;

namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Calculates the SHA256 hash of the file.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The SHA256 hash of the file as a hexadecimal string.</returns>
    public static string GetSHA256Hash(this FileInfo file)
    {
        using (var sha256 = SHA256.Create())
        using (var stream = file.OpenRead())
        {
            var hash = sha256.ComputeHash(stream);
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }
    }
}