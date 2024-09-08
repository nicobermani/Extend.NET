namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all characters from the string except the specified ones.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="charsToKeep">The characters to keep in the string.</param>
        /// <returns>A new string containing only the specified characters.</returns>
        public static string ToRemoveAllExcept(this string @this, params char[] charsToKeep)
        {
            if (string.IsNullOrEmpty(@this) || charsToKeep == null || charsToKeep.Length == 0)
                return @this;

            return new string(@this.Where(c => charsToKeep.Contains(c)).ToArray());
        }
    }
}