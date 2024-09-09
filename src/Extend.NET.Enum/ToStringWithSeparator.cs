namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Converts the enum value to a string with a custom separator between words.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="value">The enum value.</param>
        /// <param name="separator">The separator to use between words.</param>
        /// <returns>A string representation of the enum value with the specified separator.</returns>
        public static string ToStringWithSeparator<T>(this T value, string separator) where T : struct, System.Enum
        {
            return string.Join(separator, System.Text.RegularExpressions.Regex.Split(value.ToString(), @"(?<!^)(?=[A-Z])"));
        }
    }
}