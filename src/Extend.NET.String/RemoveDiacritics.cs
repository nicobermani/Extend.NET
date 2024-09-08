namespace Extend.NET.String
{
    using System.Globalization;
    using System.Text;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes diacritics (accents) from the string.
        /// </summary>
        /// <param name="this">The string to remove diacritics from.</param>
        /// <returns>The string with diacritics removed.</returns>
        public static string RemoveDiacritics(this string @this)
        {
            string normalizedString = @this.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in normalizedString)
            {
                UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}