namespace Extend.NET.String;

using System.Text;

public static partial class StringExtensions
{
    /// <summary>
    /// Converts the string to a hexadecimal string.
    /// </summary>
    /// <param name="this">The string to convert.</param>
    /// <returns>A hexadecimal representation of the input string.</returns>
    public static string ToHexString(this string @this)
    {
        var bytes = Encoding.UTF8.GetBytes(@this);
        return BitConverter.ToString(bytes).Replace("-", "");
    }
}