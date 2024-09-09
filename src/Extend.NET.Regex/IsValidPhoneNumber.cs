namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Determines whether the input string is a valid phone number.
    /// </summary>
    /// <param name="input">The string to check.</param>
    /// <returns>True if the input is a valid phone number; otherwise, false.</returns>
    public static bool IsValidPhoneNumber(this string input)
    {
        string pattern = @"^\+?(\d{1,3})?[\s.-]?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$";
        return System.Text.RegularExpressions.Regex.IsMatch(input, pattern);
    }
}