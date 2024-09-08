namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Calculates the frequency of each word in the input text.
    /// </summary>
    /// <param name="text">The input text to analyze.</param>
    /// <returns>A dictionary with words as keys and their frequencies as values.</returns>
    public static Dictionary<string, int> GetWordFrequency(this string text)
    {
        var words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        
        return words
            .GroupBy(word => word.ToLower())
            .ToDictionary(group => group.Key, group => group.Count());
    }
}