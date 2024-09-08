namespace Extend.NET.String;

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
        var iv = new byte[16];
        var buffer = Convert.FromBase64String(@this);

        using (var aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.IV = iv;
            var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

            using (var memoryStream = new MemoryStream(buffer))
            {
                using (var cryptoStream = new CryptoStream((Stream) memoryStream, decryptor, CryptoStreamMode.Read))
                {
                    using (var streamReader = new StreamReader((Stream) cryptoStream))
                    {
                        return streamReader.ReadToEnd();
                    }
                }
            }
        }
    }
}