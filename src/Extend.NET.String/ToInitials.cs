namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts the string to initials.
        /// </summary>
        /// <param name="this">The string to convert.</param>
        /// <returns>The initials extracted from the string.</returns>
        public static string ToInitials(this string @this)
        {
            if (string.IsNullOrWhiteSpace(@this))
                return string.Empty;

            return string.Join("", @this.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(s => s[0])
                                        .ToArray());
        }
    }
}