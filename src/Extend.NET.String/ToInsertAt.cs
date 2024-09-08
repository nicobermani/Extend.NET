namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Inserts a string at the specified index.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="index">The index at which to insert the string.</param>
        /// <param name="value">The string to insert.</param>
        /// <returns>A new string with the value inserted at the specified index.</returns>
        public static string ToInsertAt(this string @this, int index, string value)
        {
            if (index < 0 || index > @this.Length)
                throw new ArgumentOutOfRangeException(nameof(index));

            return @this.Insert(index, value);
        }
    }
}