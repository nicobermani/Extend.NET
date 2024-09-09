namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Replaces all occurrences of a specified regex pattern in the input string with a replacement string.
    /// </summary>
    /// <param name="input">The input string to perform replacements on.</param>
    /// <param name="pattern">The regular expression pattern to match.</param>
    /// <param name="replacement">The replacement string.</param>
    /// <returns>A new string with all occurrences of the pattern replaced.</returns>
    public static string Replace(this string input, string pattern, string replacement)
    {
        return System.Text.RegularExpressions.Regex.Replace(input, pattern, replacement);
    }
}