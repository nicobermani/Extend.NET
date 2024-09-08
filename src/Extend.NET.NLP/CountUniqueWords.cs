namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Counts the number of unique words in the input text.
    /// </summary>
    /// <param name="text">The input text to process.</param>
    /// <returns>The number of unique words in the text.</returns>
    public static int CountUniqueWords(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return 0;

        var words = text.Split(new[] {' ', '\t', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
        return words.Distinct(StringComparer.OrdinalIgnoreCase).Count();
    }
}