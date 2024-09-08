using System;
using System.Globalization;
using System.Text;

public static partial class NlpExtensions
{
    /// <summary>
    /// Removes diacritics (accent marks) from the input text.
    /// </summary>
    /// <param name="text">The input text to process.</param>
    /// <returns>The text with diacritics removed.</returns>
    public static string RemoveDiacritics(this string text)
    {
        var normalizedString = text.Normalize(NormalizationForm.FormD);
        var stringBuilder = new StringBuilder();

        foreach (var c in normalizedString)
        {
            var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
            if (unicodeCategory != UnicodeCategory.NonSpacingMark)
            {
                stringBuilder.Append(c);
            }
        }

        return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
    }
}