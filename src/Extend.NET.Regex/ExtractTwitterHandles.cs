using System.Text.RegularExpressions;

namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Extracts all Twitter handles from the input string.
    /// </summary>
    /// <param name="input">The input string to search for Twitter handles.</param>
    /// <returns>A collection of extracted Twitter handles.</returns>
    public static IEnumerable<string> ExtractTwitterHandles(this string input)
    {
        var regex = new System.Text.RegularExpressions.Regex(@"@([A-Za-z0-9_]+)");
        return regex.Matches(input).Cast<Match>().Select(m => m.Value);
    }
}