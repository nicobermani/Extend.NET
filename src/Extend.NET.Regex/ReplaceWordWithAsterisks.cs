using System.Text.RegularExpressions;

namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Replaces all occurrences of a specified word with asterisks, preserving the word's length.
    /// </summary>
    /// <param name="input">The input string to process.</param>
    /// <param name="word">The word to replace with asterisks.</param>
    /// <returns>A new string with the specified word replaced by asterisks.</returns>
    public static string ReplaceWordWithAsterisks(this string input, string word)
    {
        var pattern = $@"\b{System.Text.RegularExpressions.Regex.Escape(word)}\b";
        return System.Text.RegularExpressions.Regex.Replace(input, pattern, match => new string('*', match.Length),
            RegexOptions.IgnoreCase);
    }
}