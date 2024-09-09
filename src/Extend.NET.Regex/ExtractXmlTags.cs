using System.Text.RegularExpressions;

namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Extracts all XML tags from the input string.
    /// </summary>
    /// <param name="input">The string to extract XML tags from.</param>
    /// <returns>An array of strings containing all XML tags found in the input.</returns>
    public static string[] ExtractXmlTags(this string input)
    {
        string pattern = @"<\/?[\w\s=\""'-]+\/?>";
        return System.Text.RegularExpressions.Regex.Matches(input, pattern)
            .Cast<Match>()
            .Select(m => m.Value)
            .ToArray();
    }
}