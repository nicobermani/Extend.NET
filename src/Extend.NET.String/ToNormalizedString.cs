using System.Globalization;

namespace Extend.NET.String
{
    using System.Text;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Normalizes the string by removing diacritics and converting to lowercase.
        /// </summary>
        /// <param name="this">The string to normalize.</param>
        /// <returns>The normalized string.</returns>
        public static string ToNormalizedString(this string @this)
        {
            string normalizedString = @this.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in normalizedString)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC).ToLowerInvariant();
        }
    }
}