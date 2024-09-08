namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Replaces the first occurrence of a specified string with another string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="oldValue">The string to be replaced.</param>
        /// <param name="newValue">The string to replace the first occurrence of oldValue.</param>
        /// <returns>A new string with the first occurrence of oldValue replaced by newValue.</returns>
        public static string ToReplaceFirstOccurrence(this string @this, string oldValue, string newValue)
        {
            int index = @this.IndexOf(oldValue);
            if (index == -1)
                return @this;

            return @this.Remove(index, oldValue.Length).Insert(index, newValue);
        }
    }
}