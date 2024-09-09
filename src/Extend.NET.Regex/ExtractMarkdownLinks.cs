using System.Text.RegularExpressions;

namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Extracts all Markdown links from the input string.
    /// </summary>
    /// <param name="input">The string to extract Markdown links from.</param>
    /// <returns>An array of tuples containing the link text and URL for each Markdown link found.</returns>
    public static (string Text, string Url)[] ExtractMarkdownLinks(this string input)
    {
        string pattern = @"\[([^\]]+)\]\(([^\)]+)\)";
        return System.Text.RegularExpressions.Regex.Matches(input, pattern)
            .Cast<Match>()
            .Select(m => (m.Groups[1].Value, m.Groups[2].Value))
            .ToArray();
    }
}