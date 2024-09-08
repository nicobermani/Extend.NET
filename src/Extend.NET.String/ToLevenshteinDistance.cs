namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Calculates the Levenshtein distance between two strings.
        /// </summary>
        /// <param name="this">The first string.</param>
        /// <param name="other">The second string to compare with.</param>
        /// <returns>The Levenshtein distance between the two strings.</returns>
        public static int ToLevenshteinDistance(this string @this, string other)
        {
            int[,] distance = new int[@this.Length + 1, other.Length + 1];

            for (int i = 0; i <= @this.Length; i++)
                distance[i, 0] = i;
            for (int j = 0; j <= other.Length; j++)
                distance[0, j] = j;

            for (int i = 1; i <= @this.Length; i++)
            {
                for (int j = 1; j <= other.Length; j++)
                {
                    int cost = (@this[i - 1] == other[j - 1]) ? 0 : 1;
                    distance[i, j] = Math.Min(
                        Math.Min(distance[i - 1, j] + 1, distance[i, j - 1] + 1),
                        distance[i - 1, j - 1] + cost);
                }
            }

            return distance[@this.Length, other.Length];
        }
    }
}