using System.Text.RegularExpressions;

namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Extracts all hexadecimal color codes from the input string.
    /// Supports formats: #RGB and #RRGGBB
    /// </summary>
    /// <param name="input">The input string to search for hex color codes.</param>
    /// <returns>A collection of extracted hex color codes.</returns>
    public static IEnumerable<string> ExtractHexColors(this string input)
    {
        var regex = new System.Text.RegularExpressions.Regex(@"#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})\b");
        return regex.Matches(input).Cast<Match>().Select(m => m.Value);
    }
}