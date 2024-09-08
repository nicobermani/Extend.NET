namespace Extend.NET.String;

using System.Text;

public static partial class StringExtensions
{
    /// <summary>
    /// Converts a hexadecimal string back to its original string representation.
    /// </summary>
    /// <param name="this">The hexadecimal string to convert.</param>
    /// <returns>The original string decoded from the hexadecimal representation.</returns>
    public static string FromHexString(this string @this)
    {
        var bytes = new byte[@this.Length / 2];
        for (var i = 0; i < bytes.Length; i++) bytes[i] = Convert.ToByte(@this.Substring(i * 2, 2), 16);
        return Encoding.UTF8.GetString(bytes);
    }
}