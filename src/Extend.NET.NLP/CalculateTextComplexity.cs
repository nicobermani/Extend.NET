using System;
using System.Linq;

public static partial class NlpExtensions
{
    /// <summary>
    /// Calculates a simple text complexity score based on average word length and sentence length.
    /// </summary>
    /// <param name="text">The input text to analyze.</param>
    /// <returns>A complexity score (higher values indicate more complex text).</returns>
    public static double CalculateTextComplexity(this string text)
    {
        var sentences = text.ExtractSentences();
        var words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        double avgWordLength = words.Average(w => w.Length);
        double avgSentenceLength = words.Length / (double)sentences.Count;

        return (avgWordLength * 0.5) + (avgSentenceLength * 0.5);
    }
}