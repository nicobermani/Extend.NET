namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Tries to parse a string to the specified enum type, returning a nullable enum.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="enumType">The enum type.</param>
        /// <param name="value">The string value to parse.</param>
        /// <returns>A nullable enum value, or null if parsing fails.</returns>
        public static T? GetEnumValueAsNullable<T>(this Type enumType, string value) where T : struct, System.Enum
        {
            return System.Enum.TryParse<T>(value, true, out var result) ? result : (T?)null;
        }
    }
}