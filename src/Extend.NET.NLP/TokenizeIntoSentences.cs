using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static partial class NlpExtensions
{
    /// <summary>
    /// Tokenizes the input text into sentences using a more sophisticated approach.
    /// </summary>
    /// <param name="text">The input text to tokenize.</param>
    /// <returns>A list of sentences.</returns>
    public static List<string> TokenizeIntoSentences(this string text)
    {
        var sentences = new List<string>();
        var pattern = @"(?<=[.!?])\s+(?=[A-Z])";
        var segments = Regex.Split(text, pattern);

        foreach (var segment in segments)
        {
            var trimmedSegment = segment.Trim();
            if (!string.IsNullOrEmpty(trimmedSegment))
            {
                sentences.Add(trimmedSegment);
            }
        }

        return sentences;
    }
}