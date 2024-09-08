namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all empty lines from the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>The string with empty lines removed.</returns>
        public static string ToRemoveEmptyLines(this string @this)
        {
            return string.Join(Environment.NewLine, 
                @this.Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                     .Where(line => !string.IsNullOrWhiteSpace(line)));
        }
    }
}