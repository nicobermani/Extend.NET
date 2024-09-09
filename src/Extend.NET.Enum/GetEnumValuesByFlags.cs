namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Gets all individual enum values that are set in a flags enum value.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="value">The flags enum value.</param>
        /// <returns>An IEnumerable of individual enum values that are set in the flags enum value.</returns>
        public static IEnumerable<T> GetEnumValuesByFlags<T>(this T value) where T : struct, System.Enum
        {
            return System.Enum.GetValues(typeof(T))
                .Cast<T>()
                .Where(flag => value.HasFlag(flag) && !flag.Equals(default(T)));
        }
    }
}