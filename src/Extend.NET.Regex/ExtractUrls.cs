using System.Text.RegularExpressions;

namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Extracts all URLs from the input string.
    /// </summary>
    /// <param name="input">The string to extract URLs from.</param>
    /// <returns>An array of strings containing all URLs found in the input.</returns>
    public static string[] ExtractUrls(this string input)
    {
        var pattern =
            @"https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)";
        return System.Text.RegularExpressions.Regex.Matches(input, pattern)
            .Cast<Match>()
            .Select(m => m.Value)
            .ToArray();
    }
}