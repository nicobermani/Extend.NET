namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Removes common stop words from the input text.
    /// </summary>
    /// <param name="text">The input text to process.</param>
    /// <returns>The input text with stop words removed.</returns>
    public static string RemoveStopWords(this string text)
    {
        var stopWords = new HashSet<string> { "a", "an", "the", "in", "on", "at", "to", "for", "of", "with" };
        return string.Join(" ", text.Split().Where(word => !stopWords.Contains(word.ToLower())));
    }
}