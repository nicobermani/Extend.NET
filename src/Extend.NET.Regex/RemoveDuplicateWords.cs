using System.Text.RegularExpressions;

namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Removes duplicate words from the input string.
    /// </summary>
    /// <param name="input">The string to process.</param>
    /// <returns>A new string with duplicate words removed.</returns>
    public static string RemoveDuplicateWords(this string input)
    {
        return System.Text.RegularExpressions.Regex.Replace(input, @"\b(\w+)(?:\s+\1\b)+", "$1",
            RegexOptions.IgnoreCase);
    }
}