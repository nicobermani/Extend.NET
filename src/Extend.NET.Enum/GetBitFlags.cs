namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Gets all individual bit flags set in the enum value.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="value">The enum value.</param>
        /// <returns>An IEnumerable of individual bit flags set in the enum value.</returns>
        public static IEnumerable<T> GetBitFlags<T>(this T value) where T : struct, System.Enum
        {
            return System.Enum.GetValues(typeof(T))
                .Cast<T>()
                .Where(flag => value.HasFlag(flag));
        }
    }
}