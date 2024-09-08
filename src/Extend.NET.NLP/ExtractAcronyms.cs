using System.Text.RegularExpressions;

namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Extracts potential acronyms from the input text.
    /// </summary>
    /// <param name="text">The input text to process.</param>
    /// <returns>A list of potential acronyms found in the text.</returns>
    public static List<string> ExtractAcronyms(this string text)
    {
        var acronymPattern = @"\b[A-Z]{2,}\b";
        var matches = Regex.Matches(text, acronymPattern);
        
        var acronyms = new List<string>();
        foreach (Match match in matches)
        {
            acronyms.Add(match.Value);
        }

        return acronyms;
    }
}