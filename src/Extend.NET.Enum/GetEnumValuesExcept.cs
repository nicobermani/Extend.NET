namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Gets all enum values except the specified ones.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="enumType">The enum type.</param>
        /// <param name="valuesToExclude">The enum values to exclude.</param>
        /// <returns>An IEnumerable of enum values, excluding the specified ones.</returns>
        public static IEnumerable<T> GetEnumValuesExcept<T>(this Type enumType, params T[] valuesToExclude)
            where T : struct, System.Enum
        {
            return System.Enum.GetValues(typeof(T)).Cast<T>().Except(valuesToExclude);
        }
    }
}