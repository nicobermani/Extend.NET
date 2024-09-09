namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Determines whether the input string is a valid email address.
    /// </summary>
    /// <param name="input">The string to check.</param>
    /// <returns>True if the input is a valid email address; otherwise, false.</returns>
    public static bool IsValidEmail(this string input)
    {
        var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return System.Text.RegularExpressions.Regex.IsMatch(input, pattern);
    }
}