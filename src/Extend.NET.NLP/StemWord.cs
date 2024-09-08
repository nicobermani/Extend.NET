using System.Text.RegularExpressions;

namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Performs simple stemming on the input word using the Porter Stemming Algorithm.
    /// </summary>
    /// <param name="word">The word to stem.</param>
    /// <returns>The stemmed word.</returns>
    public static string StemWord(this string word)
    {
        if (word.Length <= 2) return word;

        word = word.ToLower();
        word = Regex.Replace(word, "ies$", "i");
        word = Regex.Replace(word, "es$", "e");
        word = Regex.Replace(word, "s$", "");
        word = Regex.Replace(word, "ing$", "");
        word = Regex.Replace(word, "ed$", "");
        word = Regex.Replace(word, "ement$", "");
        word = Regex.Replace(word, "ly$", "");
        word = Regex.Replace(word, "ness$", "");
        word = Regex.Replace(word, "ity$", "");

        return word;
    }
}