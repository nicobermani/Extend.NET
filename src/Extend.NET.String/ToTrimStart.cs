namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all leading occurrences of a specified string from the current string.
        /// </summary>
        /// <param name="this">The string to trim.</param>
        /// <param name="trimString">The string to remove from the start.</param>
        /// <returns>The string that remains after all occurrences of the trimString are removed from the start of the current string.</returns>
        public static string ToTrimStart(this string @this, string trimString)
        {
            if (string.IsNullOrEmpty(@this) || string.IsNullOrEmpty(trimString))
                return @this;

            while (@this.StartsWith(trimString))
            {
                @this = @this.Substring(trimString.Length);
            }

            return @this;
        }
    }
}