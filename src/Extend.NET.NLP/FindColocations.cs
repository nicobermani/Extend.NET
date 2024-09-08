namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Finds potential collocations (frequently co-occurring word pairs) in the input text.
    /// </summary>
    /// <param name="text">The input text to analyze.</param>
    /// <param name="minFrequency">The minimum frequency for a collocation to be considered.</param>
    /// <returns>A dictionary of collocations and their frequencies.</returns>
    public static Dictionary<string, int> FindColocations(this string text, int minFrequency = 2)
    {
        var words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        var colocations = new Dictionary<string, int>();

        for (var i = 0; i < words.Length - 1; i++)
        {
            var collocation = $"{words[i].ToLower()} {words[i + 1].ToLower()}";
            if (colocations.ContainsKey(collocation))
                colocations[collocation]++;
            else
                colocations[collocation] = 1;
        }

        return colocations.Where(kvp => kvp.Value >= minFrequency)
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    }
}