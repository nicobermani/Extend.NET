using System.Text.RegularExpressions;

namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Removes punctuation from the input text.
    /// </summary>
    /// <param name="text">The input text to process.</param>
    /// <returns>The text with punctuation removed.</returns>
    public static string RemovePunctuation(this string text)
    {
        return Regex.Replace(text, @"[^\w\s]", "");
    }
}