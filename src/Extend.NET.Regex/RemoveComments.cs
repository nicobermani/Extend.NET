namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Removes C-style comments (both single-line and multi-line) from the input string.
    /// </summary>
    /// <param name="input">The string containing code with comments to remove.</param>
    /// <returns>A new string with all C-style comments removed.</returns>
    public static string RemoveComments(this string input)
    {
        var pattern = @"(/\*([^*]|[\r\n]|(\*+([^*/]|[\r\n])))*\*+/)|(//.*)|(//.*)";
        return System.Text.RegularExpressions.Regex.Replace(input, pattern, string.Empty);
    }
}