using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static partial class NlpExtensions
{
    /// <summary>
    /// Extracts sentences from the input text.
    /// </summary>
    /// <param name="text">The input text to process.</param>
    /// <returns>A list of extracted sentences.</returns>
    public static List<string> ExtractSentences(this string text)
    {
        var sentencePattern = @"(?<=[.!?])\s+(?=[A-Z])";
        var sentences = Regex.Split(text.Trim(), sentencePattern)
                             .Where(s => !string.IsNullOrWhiteSpace(s))
                             .ToList();

        return sentences;
    }
}