namespace Extend.NET.String
{
    using System.Security.Cryptography;
    using System.Text;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Decrypts the string using AES decryption.
        /// </summary>
        /// <param name="this">The encrypted string to decrypt.</param>
        /// <param name="key">The decryption key.</param>
        /// <returns>The decrypted string.</returns>
        public static string Decrypt(this string @this, string key)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(@this);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}