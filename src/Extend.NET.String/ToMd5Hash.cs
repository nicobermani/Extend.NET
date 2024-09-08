namespace Extend.NET.String;

using System.Security.Cryptography;
using System.Text;

public static partial class StringExtensions
{
    /// <summary>
    /// Computes the MD5 hash of the string.
    /// </summary>
    /// <param name="this">The string to hash.</param>
    /// <returns>The MD5 hash of the string.</returns>
    public static string ToMd5Hash(this string @this)
    {
        using (var md5 = MD5.Create())
        {
            var inputBytes = Encoding.ASCII.GetBytes(@this);
            var hashBytes = md5.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            for (var i = 0; i < hashBytes.Length; i++) sb.Append(hashBytes[i].ToString("X2"));
            return sb.ToString();
        }
    }
}