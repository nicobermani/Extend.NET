namespace Extend.NET.String;

using System.Globalization;

public static partial class StringExtensions
{
    /// <summary>
    /// Converts the string to title case, but keeps specified words in lowercase.
    /// </summary>
    /// <param name="this">The string to convert.</param>
    /// <param name="lowercaseWords">Words to keep in lowercase.</param>
    /// <returns>The string converted to title case with exceptions.</returns>
    public static string ToTitleCaseWithExceptions(this string @this, params string[] lowercaseWords)
    {
        var textInfo = CultureInfo.CurrentCulture.TextInfo;
        string[] words = @this.Split(' ');

        for (var i = 0; i < words.Length; i++)
            if (!lowercaseWords.Contains(words[i], StringComparer.OrdinalIgnoreCase))
                words[i] = textInfo.ToTitleCase(words[i].ToLower());

        return string.Join(" ", words);
    }
}