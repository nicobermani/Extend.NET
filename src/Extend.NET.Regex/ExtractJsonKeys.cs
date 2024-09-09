using System.Text.RegularExpressions;

namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Extracts all JSON keys from the input string.
    /// </summary>
    /// <param name="input">The JSON string to extract keys from.</param>
    /// <returns>An array of strings containing all JSON keys found in the input.</returns>
    public static string[] ExtractJsonKeys(this string input)
    {
        var pattern = @"(?<="")(\w+)(?=""\s*:)";
        return System.Text.RegularExpressions.Regex.Matches(input, pattern)
            .Cast<Match>()
            .Select(m => m.Value)
            .ToArray();
    }
}