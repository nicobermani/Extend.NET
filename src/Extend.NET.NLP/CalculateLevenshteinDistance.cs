using System;

public static partial class NlpExtensions
{
    /// <summary>
    /// Calculates the Levenshtein distance between two strings.
    /// </summary>
    /// <param name="source">The source string.</param>
    /// <param name="target">The target string to compare with.</param>
    /// <returns>The Levenshtein distance between the two strings.</returns>
    public static int CalculateLevenshteinDistance(this string source, string target)
    {
        int[,] distance = new int[source.Length + 1, target.Length + 1];

        for (int i = 0; i <= source.Length; i++)
            distance[i, 0] = i;
        for (int j = 0; j <= target.Length; j++)
            distance[0, j] = j;

        for (int i = 1; i <= source.Length; i++)
        {
            for (int j = 1; j <= target.Length; j++)
            {
                int cost = (source[i - 1] == target[j - 1]) ? 0 : 1;
                distance[i, j] = Math.Min(
                    Math.Min(distance[i - 1, j] + 1, distance[i, j - 1] + 1),
                    distance[i - 1, j - 1] + cost);
            }
        }

        return distance[source.Length, target.Length];
    }
}