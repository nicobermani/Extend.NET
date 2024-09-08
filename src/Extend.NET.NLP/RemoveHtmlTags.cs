using System.Text.RegularExpressions;

namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Removes HTML tags from the input text.
    /// </summary>
    /// <param name="text">The input text containing HTML tags.</param>
    /// <returns>The text with HTML tags removed.</returns>
    public static string RemoveHtmlTags(this string text)
    {
        return Regex.Replace(text, "<.*?>", string.Empty);
    }
}