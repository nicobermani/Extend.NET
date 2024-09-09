namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Trims excess whitespace from the input string, leaving only single spaces between words.
    /// </summary>
    /// <param name="input">The string to trim.</param>
    /// <returns>A new string with excess whitespace removed.</returns>
    public static string TrimExcessWhitespace(this string input)
    {
        return System.Text.RegularExpressions.Regex.Replace(input, @"\s+", " ").Trim();
    }
}