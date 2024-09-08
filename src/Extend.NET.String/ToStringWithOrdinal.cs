namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts a numeric string to a string with an ordinal suffix (e.g., "1st", "2nd", "3rd", "4th").
        /// </summary>
        /// <param name="this">The numeric string to convert.</param>
        /// <returns>The string with an ordinal suffix.</returns>
        public static string ToStringWithOrdinal(this string @this)
        {
            if (!int.TryParse(@this, out int number))
                return @this;

            string suffix = (number % 100) switch
            {
                11 or 12 or 13 => "th",
                _ => (number % 10) switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                }
            };

            return $"{@this}{suffix}";
        }
    }
}