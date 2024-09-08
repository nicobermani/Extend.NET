using System.Text.RegularExpressions;

namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Extracts hashtags from the input text.
    /// </summary>
    /// <param name="text">The input text to process.</param>
    /// <returns>A list of hashtags found in the text.</returns>
    public static List<string> ExtractHashtags(this string text)
    {
        var hashtagPattern = @"#\w+";
        var matches = Regex.Matches(text, hashtagPattern);

        var hashtags = new List<string>();
        foreach (Match match in matches) hashtags.Add(match.Value);

        return hashtags;
    }
}