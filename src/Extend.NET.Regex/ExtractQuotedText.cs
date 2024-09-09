using System.Text.RegularExpressions;

namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Extracts all text enclosed in double quotes from the input string.
    /// </summary>
    /// <param name="input">The string to extract quoted text from.</param>
    /// <returns>An array of strings containing all quoted text found in the input.</returns>
    public static string[] ExtractQuotedText(this string input)
    {
        var pattern = @"""([^""\\]*(?:\\.[^""\\]*)*)""";
        return System.Text.RegularExpressions.Regex.Matches(input, pattern)
            .Cast<Match>()
            .Select(m => m.Groups[1].Value)
            .ToArray();
    }
}