using System.Text.RegularExpressions;

namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Extracts all Markdown headers from the input string.
    /// Supports headers from level 1 (# Header) to level 6 (###### Header).
    /// </summary>
    /// <param name="input">The input string to search for Markdown headers.</param>
    /// <returns>A collection of extracted Markdown headers.</returns>
    public static IEnumerable<string> ExtractMarkdownHeaders(this string input)
    {
        var regex = new System.Text.RegularExpressions.Regex(@"^#{1,6}\s+.+$", RegexOptions.Multiline);
        return regex.Matches(input).Cast<Match>().Select(m => m.Value);
    }
}