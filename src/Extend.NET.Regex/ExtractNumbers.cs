using System.Text.RegularExpressions;

namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Extracts all numbers from the input string.
    /// </summary>
    /// <param name="input">The string to extract numbers from.</param>
    /// <returns>An array of strings containing all numbers found in the input.</returns>
    public static string[] ExtractNumbers(this string input)
    {
        return System.Text.RegularExpressions.Regex.Matches(input, @"\d+")
            .Cast<Match>()
            .Select(m => m.Value)
            .ToArray();
    }
}