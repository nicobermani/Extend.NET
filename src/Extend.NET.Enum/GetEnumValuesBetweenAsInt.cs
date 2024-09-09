namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Gets all integer values of enum members between two specified values (inclusive).
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="enumType">The enum type.</param>
        /// <param name="start">The start value.</param>
        /// <param name="end">The end value.</param>
        /// <returns>An IEnumerable of integer values between the start and end values.</returns>
        public static IEnumerable<int> GetEnumValuesBetweenAsInt<T>(this Type enumType, T start, T end)
            where T : struct, System.Enum
        {
            var startValue = Convert.ToInt32(start);
            var endValue = Convert.ToInt32(end);
            return System.Enum.GetValues(typeof(T))
                .Cast<T>()
                .Select(v => Convert.ToInt32(v))
                .Where(v => v >= startValue && v <= endValue);
        }
    }
}