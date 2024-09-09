using System.Text.RegularExpressions;

namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Extracts all acronyms (words consisting of capital letters) from the input string.
    /// </summary>
    /// <param name="input">The input string to search for acronyms.</param>
    /// <returns>A collection of extracted acronyms.</returns>
    public static IEnumerable<string> ExtractAcronyms(this string input)
    {
        var regex = new System.Text.RegularExpressions.Regex(@"\b[A-Z]{2,}\b");
        return regex.Matches(input).Cast<Match>().Select(m => m.Value);
    }
}