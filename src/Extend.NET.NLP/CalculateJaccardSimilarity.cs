namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Calculates the Jaccard similarity between two strings.
    /// </summary>
    /// <param name="text1">The first string to compare.</param>
    /// <param name="text2">The second string to compare.</param>
    /// <returns>The Jaccard similarity score between 0 and 1.</returns>
    public static double CalculateJaccardSimilarity(this string text1, string text2)
    {
        var set1 = new HashSet<string>(text1.ToLower().Split());
        var set2 = new HashSet<string>(text2.ToLower().Split());

        var intersectionCount = set1.Intersect(set2).Count();
        var unionCount = set1.Union(set2).Count();

        return (double)intersectionCount / unionCount;
    }
}