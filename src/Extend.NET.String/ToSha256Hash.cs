namespace Extend.NET.String
{
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
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(@this);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}