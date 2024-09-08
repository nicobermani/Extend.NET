namespace Extend.NET.String
{
    using System.Security.Cryptography;
    using System.Text;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Encrypts the string using AES encryption.
        /// </summary>
        /// <param name="this">The string to encrypt.</param>
        /// <param name="key">The encryption key.</param>
        /// <returns>The encrypted string as a base64-encoded string.</returns>
        public static string Encrypt(this string @this, string key)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(@this);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }
    }
}