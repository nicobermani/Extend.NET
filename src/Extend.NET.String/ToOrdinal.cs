namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts a numeric string to its ordinal representation.
        /// </summary>
        /// <param name="this">The numeric string to convert.</param>
        /// <returns>The ordinal representation of the number.</returns>
        public static string ToOrdinal(this string @this)
        {
            if (!int.TryParse(@this, out var number))
                return @this;

            if (number <= 0) return @this;

            switch (number % 100)
            {
                case 11:
                case 12:
                case 13:
                    return @this + "th";
            }

            switch (number % 10)
            {
                case 1:
                    return @this + "st";
                case 2:
                    return @this + "nd";
                case 3:
                    return @this + "rd";
                default:
                    return @this + "th";
            }
        }
    }
}