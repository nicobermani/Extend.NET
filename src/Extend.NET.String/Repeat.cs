namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Repeats the string a specified number of times.
        /// </summary>
        /// <param name="this">The string to repeat.</param>
        /// <param name="count">The number of times to repeat the string.</param>
        /// <returns>A new string containing the original string repeated the specified number of times.</returns>
        public static string Repeat(this string @this, int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count), "Count cannot be negative.");

            return string.Concat(Enumerable.Repeat(@this, count));
        }
    }
}