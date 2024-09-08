namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts the string to an initialism (acronym) by taking the first letter of each word.
        /// </summary>
        /// <param name="this">The string to convert to an initialism.</param>
        /// <returns>The initialism derived from the string.</returns>
        public static string ToInitialism(this string @this)
        {
            if (string.IsNullOrEmpty(@this))
                return @this;

            return new string(@this.Split(' ').Where(w => !string.IsNullOrEmpty(w)).Select(w => char.ToUpper(w[0])).ToArray());
        }
    }
}