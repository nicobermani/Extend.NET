using System.Text.RegularExpressions;

namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Extracts URLs from the input text.
    /// </summary>
    /// <param name="text">The input text to process.</param>
    /// <returns>A list of URLs found in the text.</returns>
    public static List<string> ExtractUrls(this string text)
    {
        var urlPattern = @"https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)";
        var matches = Regex.Matches(text, urlPattern);
        
        var urls = new List<string>();
        foreach (Match match in matches)
        {
            urls.Add(match.Value);
        }

        return urls;
    }
}