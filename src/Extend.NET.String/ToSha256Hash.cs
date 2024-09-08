namespace Extend.NET.String;

using System.Security.Cryptography;
using System.Text;

public static partial class StringExtensions
{
    /// <summary>
    /// Computes the SHA256 hash of the string.
    /// </summary>
    /// <param name="this">The string to hash.</param>
    /// <returns>The SHA256 hash of the string.</returns>
    public static string ToSha256Hash(this string @this)
    {
        using (var sha256 = SHA256.Create())
        {
            var inputBytes = Encoding.UTF8.GetBytes(@this);
            var hashBytes = sha256.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            for (var i = 0; i < hashBytes.Length; i++) sb.Append(hashBytes[i].ToString("x2"));
            return sb.ToString();
        }
    }
}