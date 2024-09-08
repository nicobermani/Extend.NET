namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all trailing occurrences of a specified string from the current string.
        /// </summary>
        /// <param name="this">The string to trim.</param>
        /// <param name="trimString">The string to remove from the end.</param>
        /// <returns>The string that remains after all occurrences of the trimString are removed from the end of the current string.</returns>
        public static string ToTrimEnd(this string @this, string trimString)
        {
            if (string.IsNullOrEmpty(@this) || string.IsNullOrEmpty(trimString))
                return @this;

            while (@this.EndsWith(trimString))
            {
                @this = @this.Substring(0, @this.Length - trimString.Length);
            }

            return @this;
        }
    }
}