namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Gets all enum values except those set in the specified flags enum value.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="enumType">The enum type.</param>
        /// <param name="flags">The flags enum value to exclude.</param>
        /// <returns>An IEnumerable of enum values not set in the specified flags enum value.</returns>
        public static IEnumerable<T> GetEnumValuesExceptFlags<T>(this Type enumType, T flags) where T : struct, System.Enum
        {
            return System.Enum.GetValues(typeof(T))
                .Cast<T>()
                .Where(value => !flags.HasFlag(value) || value.Equals(default(T)));
        }
    }
}