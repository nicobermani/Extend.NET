using System.Text.RegularExpressions;

namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Normalizes the input text by removing special characters, extra spaces, and converting to lowercase.
    /// </summary>
    /// <param name="text">The input text to normalize.</param>
    /// <returns>The normalized text.</returns>
    public static string NormalizeText(this string text)
    {
        // Remove special characters
        text = Regex.Replace(text, @"[^a-zA-Z0-9\s]", "");

        // Convert to lowercase
        text = text.ToLower();

        // Remove extra spaces
        text = Regex.Replace(text, @"\s+", " ").Trim();

        return text;
    }
}