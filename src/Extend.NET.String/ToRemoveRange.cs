namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes a range of characters from the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="startIndex">The start index of the range to remove.</param>
        /// <param name="count">The number of characters to remove.</param>
        /// <returns>A new string with the specified range removed.</returns>
        public static string ToRemoveRange(this string @this, int startIndex, int count)
        {
            if (startIndex < 0 || startIndex >= @this.Length)
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            if (count < 0 || startIndex + count > @this.Length)
                throw new ArgumentOutOfRangeException(nameof(count));

            return @this.Remove(startIndex, count);
        }
    }
}