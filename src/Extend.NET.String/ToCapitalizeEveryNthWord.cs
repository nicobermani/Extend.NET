namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Capitalizes every nth word in the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="n">The interval at which to capitalize words.</param>
        /// <returns>A new string with every nth word capitalized.</returns>
        public static string ToCapitalizeEveryNthWord(this string @this, int n)
        {
            if (string.IsNullOrWhiteSpace(@this) || n <= 0)
                return @this;

            return string.Join(" ", @this.Split(' ')
                .Select((word, index) => (index + 1) % n == 0 ? word.ToUpper() : word));
        }
    }
}