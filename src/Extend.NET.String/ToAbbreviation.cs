namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts a string to its abbreviated form.
        /// </summary>
        /// <param name="this">The string to abbreviate.</param>
        /// <param name="maxLength">The maximum length of the abbreviated string.</param>
        /// <returns>The abbreviated string.</returns>
        public static string ToAbbreviation(this string @this, int maxLength = 3)
        {
            if (string.IsNullOrEmpty(@this) || @this.Length <= maxLength)
                return @this;

            var words = @this.Split(' ');
            return string.Join("", words.Select(w => w[0])).Substring(0, Math.Min(maxLength, words.Length));
        }
    }
}