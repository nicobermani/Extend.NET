namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Removes all non-alphanumeric characters from the input string.
    /// </summary>
    /// <param name="input">The string to process.</param>
    /// <returns>A new string with all non-alphanumeric characters removed.</returns>
    public static string RemoveNonAlphanumeric(this string input)
    {
        return System.Text.RegularExpressions.Regex.Replace(input, @"[^a-zA-Z0-9]", string.Empty);
    }
}