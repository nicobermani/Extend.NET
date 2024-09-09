namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Determines whether the input string is a valid US Social Security Number (SSN).
    /// </summary>
    /// <param name="input">The string to check.</param>
    /// <returns>True if the input is a valid SSN; otherwise, false.</returns>
    public static bool IsValidSSN(this string input)
    {
        string pattern = @"^(?!000|666|9\d{2})\d{3}-(?!00)\d{2}-(?!0000)\d{4}$";
        return System.Text.RegularExpressions.Regex.IsMatch(input, pattern);
    }
}