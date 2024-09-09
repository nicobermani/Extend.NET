using System.Text.RegularExpressions;

namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Splits a camelCase or PascalCase string into separate words.
    /// </summary>
    /// <param name="input">The camelCase or PascalCase string to split.</param>
    /// <returns>A string with space-separated words.</returns>
    public static string SplitCamelCase(this string input)
    {
        return System.Text.RegularExpressions.Regex.Replace(input, "([A-Z])", " $1", RegexOptions.Compiled).Trim();
    }
}