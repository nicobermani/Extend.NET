using System.Text.RegularExpressions;

namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Extracts all phone numbers from the input string.
    /// Supports formats like (123) 456-7890, 123-456-7890, and 1234567890.
    /// </summary>
    /// <param name="input">The input string to search for phone numbers.</param>
    /// <returns>A collection of extracted phone numbers.</returns>
    public static IEnumerable<string> ExtractPhoneNumbers(this string input)
    {
        var regex = new System.Text.RegularExpressions.Regex(@"\(?\d{3}\)?[-.\s]?\d{3}[-.\s]?\d{4}");
        return regex.Matches(input).Cast<Match>().Select(m => m.Value);
    }
}