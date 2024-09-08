namespace Extend.NET.String;

using System.Security;

public static partial class StringExtensions
{
    /// <summary>
    /// Converts the string to a SecureString.
    /// </summary>
    /// <param name="this">The string to convert.</param>
    /// <returns>A SecureString representation of the input string.</returns>
    public static SecureString ToSecureString(this string @this)
    {
        var secureString = new SecureString();
        foreach (var c in @this) secureString.AppendChar(c);
        secureString.MakeReadOnly();
        return secureString;
    }
}