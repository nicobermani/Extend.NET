using System.Text.RegularExpressions;

namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Expands common English contractions in the input text.
    /// </summary>
    /// <param name="text">The input text to process.</param>
    /// <returns>The text with expanded contractions.</returns>
    public static string ExpandContractions(this string text)
    {
        var contractions = new Dictionary<string, string>
        {
            {@"\bi'm\b", "I am"},
            {@"\bdon't\b", "do not"},
            {@"\bcan't\b", "cannot"},
            {@"\bwon't\b", "will not"},
            {@"\bisn't\b", "is not"},
            {@"\baren't\b", "are not"},
            {@"\bwasn't\b", "was not"},
            {@"\bweren't\b", "were not"},
            {@"\bhasn't\b", "has not"},
            {@"\bhaven't\b", "have not"},
            {@"\bhadn't\b", "had not"},
            {@"\bwouldn't\b", "would not"},
            {@"\bcouldn't\b", "could not"},
            {@"\bshouldn't\b", "should not"},
            {@"\blet's\b", "let us"}
        };

        foreach (var contraction in contractions)
            text = Regex.Replace(text, contraction.Key, contraction.Value, RegexOptions.IgnoreCase);

        return text;
    }
}