namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Estimates the number of syllables in a word.
    /// </summary>
    /// <param name="word">The word to analyze.</param>
    /// <returns>The estimated number of syllables in the word.</returns>
    public static int CountSyllables(this string word)
    {
        word = word.ToLower().Trim();
        if (word.Length <= 3) return 1;

        word = word.Replace("es", "").Replace("ed", "");
        var vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'y' };
        int count = 0;
        bool lastWasVowel = false;

        foreach (char c in word)
        {
            bool isVowel = vowels.Contains(c);
            if (isVowel && !lastWasVowel) count++;
            lastWasVowel = isVowel;
        }

        if (word.EndsWith("e")) count--;
        if (word.EndsWith("le")) count++;
        if (count == 0) count = 1;

        return count;
    }
}