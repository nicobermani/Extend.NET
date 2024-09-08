namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Extracts potential keywords from the input text based on word frequency.
    /// </summary>
    /// <param name="text">The input text to process.</param>
    /// <param name="topN">The number of top keywords to return.</param>
    /// <returns>An array of the most frequent words as potential keywords.</returns>
    public static string[] ExtractKeywords(this string text, int topN = 5)
    {
        var words = text.ToLower().Split()
            .Where(w => w.Length > 3)
            .GroupBy(w => w)
            .OrderByDescending(g => g.Count())
            .Take(topN)
            .Select(g => g.Key)
            .ToArray();

        return words;
    }
}