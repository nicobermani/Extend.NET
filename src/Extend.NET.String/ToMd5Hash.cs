namespace Extend.NET.String
{
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
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(@this);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}