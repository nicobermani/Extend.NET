namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Gets all enum values between two specified values (inclusive).
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="enumType">The enum type.</param>
        /// <param name="start">The start value.</param>
        /// <param name="end">The end value.</param>
        /// <returns>An IEnumerable of enum values between the start and end values.</returns>
        public static IEnumerable<T> GetEnumValuesBetween<T>(this Type enumType, T start, T end) where T : struct, Enum
        {
            int startValue = Convert.ToInt32(start);
            int endValue = Convert.ToInt32(end);
            return Enum.GetValues(typeof(T))
                .Cast<T>()
                .Where(v => Convert.ToInt32(v) >= startValue && Convert.ToInt32(v) <= endValue);
        }
    }
}