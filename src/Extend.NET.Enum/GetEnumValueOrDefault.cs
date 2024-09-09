namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Tries to parse a string to the specified enum type, returning a default value if parsing fails.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="enumType">The enum type.</param>
        /// <param name="value">The string value to parse.</param>
        /// <param name="defaultValue">The default value to return if parsing fails.</param>
        /// <returns>The parsed enum value, or the default value if parsing fails.</returns>
        public static T GetEnumValueOrDefault<T>(this Type enumType, string value, T defaultValue) where T : struct, System.Enum
        {
            return System.Enum.TryParse<T>(value, true, out var result) ? result : defaultValue;
        }
    }
}