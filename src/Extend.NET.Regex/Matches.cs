using System.Text.RegularExpressions;

namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Searches the input string for all occurrences of a regular expression pattern.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="pattern">The regular expression pattern to match.</param>
    /// <returns>A collection of all matches found in the input string.</returns>
    public static MatchCollection Matches(this string input, string pattern)
    {
        return System.Text.RegularExpressions.Regex.Matches(input, pattern);
    }
}