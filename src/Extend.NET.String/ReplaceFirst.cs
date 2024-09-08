namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Replaces the first occurrence of a specified string with another string.
        /// </summary>
        /// <param name="this">The source string.</param>
        /// <param name="oldValue">The string to be replaced.</param>
        /// <param name="newValue">The string to replace the first occurrence of oldValue.</param>
        /// <returns>A new string with the first occurrence of oldValue replaced by newValue.</returns>
        public static string ReplaceFirst(this string @this, string oldValue, string newValue)
        {
            int index = @this.IndexOf(oldValue);
            if (index < 0)
                return @this;

            return @this.Substring(0, index) + newValue + @this.Substring(index + oldValue.Length);
        }
    }
}