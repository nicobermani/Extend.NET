namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Replaces the last occurrence of a specified string with another string.
        /// </summary>
        /// <param name="this">The source string.</param>
        /// <param name="oldValue">The string to be replaced.</param>
        /// <param name="newValue">The string to replace the last occurrence of oldValue.</param>
        /// <returns>A new string with the last occurrence of oldValue replaced by newValue.</returns>
        public static string ReplaceLast(this string @this, string oldValue, string newValue)
        {
            int index = @this.LastIndexOf(oldValue);
            if (index < 0)
                return @this;

            return @this.Substring(0, index) + newValue + @this.Substring(index + oldValue.Length);
        }
    }
}