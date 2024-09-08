using System.Text.RegularExpressions;

namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Extracts numbers from the input text.
    /// </summary>
    /// <param name="text">The input text to process.</param>
    /// <returns>A list of numbers found in the text.</returns>
    public static List<string> ExtractNumbers(this string text)
    {
        var numberPattern = @"[-+]?[0-9]*\.?[0-9]+";
        var matches = Regex.Matches(text, numberPattern);
        
        var numbers = new List<string>();
        foreach (Match match in matches)
        {
            numbers.Add(match.Value);
        }

        return numbers;
    }
}