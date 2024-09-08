using System.Text.RegularExpressions;

namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Converts the input text to camelCase.
    /// </summary>
    /// <param name="text">The input text to convert.</param>
    /// <returns>The text converted to camelCase.</returns>
    public static string ConvertToCamelCase(this string text)
    {
        if (string.IsNullOrEmpty(text))
            return text;

        text = Regex.Replace(text, @"[^a-zA-Z0-9]+", " ");
        text = text.Trim();
        
        var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var result = words[0].ToLower();

        for (int i = 1; i < words.Length; i++)
        {
            result += char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
        }

        return result;
    }
}