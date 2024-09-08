namespace Extend.NET.String
{
    using System.Collections.Generic;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Replaces multiple substrings in the string with their corresponding replacements.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="replacements">A dictionary of substrings to replace and their replacements.</param>
        /// <returns>A new string with all specified replacements made.</returns>
        public static string ToReplaceMultiple(this string @this, Dictionary<string, string> replacements)
        {
            if (string.IsNullOrEmpty(@this) || replacements == null || replacements.Count == 0)
                return @this;

            foreach (var replacement in replacements)
            {
                @this = @this.Replace(replacement.Key, replacement.Value);
            }

            return @this;
        }
    }
}