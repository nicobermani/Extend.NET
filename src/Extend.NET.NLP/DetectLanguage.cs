using System;
using System.Collections.Generic;
using System.Linq;

public static partial class NlpExtensions
{
    /// <summary>
    /// Attempts to detect the language of the input text based on common words.
    /// </summary>
    /// <param name="text">The input text to analyze.</param>
    /// <returns>A string representing the detected language (e.g., "en" for English, "es" for Spanish).</returns>
    public static string DetectLanguage(this string text)
    {
        var languageProfiles = new Dictionary<string, HashSet<string>>
        {
            {"en", new HashSet<string> { "the", "be", "to", "of", "and", "in", "that", "have" }},
            {"es", new HashSet<string> { "el", "la", "de", "que", "y", "en", "un", "ser" }},
            {"fr", new HashSet<string> { "le", "la", "de", "et", "un", "être", "que", "à" }}
        };

        var words = text.ToLower().Split();
        var scores = languageProfiles.ToDictionary(
            kvp => kvp.Key,
            kvp => words.Count(w => kvp.Value.Contains(w))
        );

        return scores.OrderByDescending(kvp => kvp.Value).First().Key;
    }
}