using System;

public static partial class NlpExtensions
{
    /// <summary>
    /// Calculates the similarity between two words using the Jaro-Winkler distance.
    /// </summary>
    /// <param name="word1">The first word to compare.</param>
    /// <param name="word2">The second word to compare.</param>
    /// <returns>A similarity score between 0 and 1, where 1 indicates identical words.</returns>
    public static double CalculateWordSimilarity(this string word1, string word2)
    {
        int m = 0;
        int t = 0;
        int maxLength = Math.Max(word1.Length, word2.Length);
        int matchDistance = Math.Max(maxLength / 2 - 1, 0);

        for (int i = 0; i < word1.Length; i++)
        {
            int start = Math.Max(0, i - matchDistance);
            int end = Math.Min(i + matchDistance + 1, word2.Length);

            for (int j = start; j < end; j++)
            {
                if (word1[i] == word2[j])
                {
                    m++;
                    if (Math.Abs(i - j) <= 1)
                    {
                        t++;
                    }
                    break;
                }
            }
        }

        if (m == 0)
            return 0;

        double dj = (m / (double)word1.Length + m / (double)word2.Length + (m - t / 2.0) / m) / 3.0;
        double p = 0.1;
        int l = 0;

        for (int i = 0; i < Math.Min(4, Math.Min(word1.Length, word2.Length)); i++)
        {
            if (word1[i] == word2[i])
                l++;
            else
                break;
        }

        return dj + l * p * (1 - dj);
    }
}