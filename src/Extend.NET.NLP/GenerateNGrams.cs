using System;
using System.Collections.Generic;
using System.Linq;

public static partial class NlpExtensions
{
    /// <summary>
    /// Generates n-grams from the input text.
    /// </summary>
    /// <param name="text">The input text to process.</param>
    /// <param name="n">The size of the n-grams to generate.</param>
    /// <returns>A list of n-grams generated from the input text.</returns>
    public static List<string> GenerateNGrams(this string text, int n)
    {
        if (n <= 0)
            throw new ArgumentException("N must be a positive integer.", nameof(n));

        var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var nGrams = new List<string>();

        for (int i = 0; i <= words.Length - n; i++)
        {
            nGrams.Add(string.Join(" ", words.Skip(i).Take(n)));
        }

        return nGrams;
    }
}