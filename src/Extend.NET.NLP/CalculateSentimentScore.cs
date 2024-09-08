using System;
using System.Collections.Generic;
using System.Linq;

public static partial class NlpExtensions
{
    /// <summary>
    /// Calculates a simple sentiment score for the input text.
    /// </summary>
    /// <param name="text">The input text to analyze.</param>
    /// <returns>A sentiment score between -1 (negative) and 1 (positive).</returns>
    public static double CalculateSentimentScore(this string text)
    {
        var positiveWords = new HashSet<string> { "good", "great", "excellent", "happy", "positive" };
        var negativeWords = new HashSet<string> { "bad", "terrible", "awful", "sad", "negative" };

        var words = text.ToLower().Split();
        int positiveCount = words.Count(w => positiveWords.Contains(w));
        int negativeCount = words.Count(w => negativeWords.Contains(w));

        return (positiveCount - negativeCount) / (double)words.Length;
    }
}