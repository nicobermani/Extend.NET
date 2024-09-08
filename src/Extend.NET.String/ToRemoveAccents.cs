namespace Extend.NET.String;

using System.Globalization;
using System.Text;

public static partial class StringExtensions
{
    /// <summary>
    /// Removes all accents from the string.
    /// </summary>
    /// <param name="this">The string to process.</param>
    /// <returns>The string with accents removed.</returns>
    public static string ToRemoveAccents(this string @this)
    {
        if (string.IsNullOrWhiteSpace(@this))
            return @this;

        var normalizedString = @this.Normalize(NormalizationForm.FormD);
        var stringBuilder = new StringBuilder();

        foreach (var c in normalizedString)
        {
            var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
            if (unicodeCategory != UnicodeCategory.NonSpacingMark) stringBuilder.Append(c);
        }

        return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
    }
}