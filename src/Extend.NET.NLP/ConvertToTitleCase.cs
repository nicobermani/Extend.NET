using System.Globalization;

namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Converts the input text to title case.
    /// </summary>
    /// <param name="text">The input text to convert.</param>
    /// <returns>The input text converted to title case.</returns>
    public static string ConvertToTitleCase(this string text)
    {
        var textInfo = new CultureInfo("en-US", false).TextInfo;
        return textInfo.ToTitleCase(text.ToLower());
    }
}