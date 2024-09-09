namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Converts the enum value to a friendly string by inserting spaces before capital letters.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="value">The enum value.</param>
        /// <returns>A friendly string representation of the enum value.</returns>
        public static string ToFriendlyString<T>(this T value) where T : struct, Enum
        {
            return System.Text.RegularExpressions.Regex.Replace(value.ToString(), "([a-z])([A-Z])", "$1 $2");
        }
    }
}