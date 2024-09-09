namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Normalizes whitespace in the input string by replacing multiple consecutive
    /// whitespace characters (including newlines and tabs) with a single space.
    /// </summary>
    /// <param name="input">The input string to normalize.</param>
    /// <returns>A string with normalized whitespace.</returns>
    public static string NormalizeWhitespace(this string input)
    {
        return System.Text.RegularExpressions.Regex.Replace(input, @"\s+", " ").Trim();
    }
}