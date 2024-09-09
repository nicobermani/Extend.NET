using System.Text.RegularExpressions;

namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Extracts all dates from the input string.
    /// Supports formats: MM/DD/YYYY, MM-DD-YYYY, YYYY-MM-DD
    /// </summary>
    /// <param name="input">The string to extract dates from.</param>
    /// <returns>An array of strings containing all dates found in the input.</returns>
    public static string[] ExtractDates(this string input)
    {
        string pattern = @"\b(?:(?:0?[1-9]|1[0-2])[/\-](?:0?[1-9]|[12]\d|3[01])[/\-](?:19|20)\d{2}|(?:19|20)\d{2}[/\-](?:0?[1-9]|1[0-2])[/\-](?:0?[1-9]|[12]\d|3[01]))\b";
        return System.Text.RegularExpressions.Regex.Matches(input, pattern)
            .Cast<Match>()
            .Select(m => m.Value)
            .ToArray();
    }
}