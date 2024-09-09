namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Checks if the enum value is within the specified range.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="value">The enum value to check.</param>
        /// <param name="start">The start of the range (inclusive).</param>
        /// <param name="end">The end of the range (inclusive).</param>
        /// <returns>True if the value is within the range, false otherwise.</returns>
        public static bool IsInRange<T>(this T value, T start, T end) where T : struct, System.Enum
        {
            int iValue = Convert.ToInt32(value);
            int iStart = Convert.ToInt32(start);
            int iEnd = Convert.ToInt32(end);
            return iValue >= iStart && iValue <= iEnd;
        }
    }
}