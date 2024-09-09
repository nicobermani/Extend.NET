namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Removes all special characters from the input string, leaving only letters and numbers.
    /// </summary>
    /// <param name="input">The string to process.</param>
    /// <returns>A new string with all special characters removed.</returns>
    public static string RemoveSpecialCharacters(this string input)
    {
        return System.Text.RegularExpressions.Regex.Replace(input, @"[^a-zA-Z0-9]", string.Empty);
    }
}