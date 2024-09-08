using System;
using System.Linq;

public static partial class NlpExtensions
{
    /// <summary>
    /// Calculates a simple readability score (Flesch-Kincaid Grade Level) for the input text.
    /// </summary>
    /// <param name="text">The input text to analyze.</param>
    /// <returns>The Flesch-Kincaid Grade Level score.</returns>
    public static double CalculateReadabilityScore(this string text)
    {
        var sentences = text.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        var words = text.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        
        double totalSyllables = words.Sum(w => w.CountSyllables());
        double avgSentenceLength = (double)words.Length / sentences.Length;
        double avgSyllablesPerWord = totalSyllables / words.Length;

        return 0.39 * avgSentenceLength + 11.8 * avgSyllablesPerWord - 15.59;
    }
}