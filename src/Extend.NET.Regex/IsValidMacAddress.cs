namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Determines whether the input string is a valid MAC address.
    /// </summary>
    /// <param name="input">The string to check.</param>
    /// <returns>True if the input is a valid MAC address; otherwise, false.</returns>
    public static bool IsValidMacAddress(this string input)
    {
        var pattern = @"^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$";
        return System.Text.RegularExpressions.Regex.IsMatch(input, pattern);
    }
}