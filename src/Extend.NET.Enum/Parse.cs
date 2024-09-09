namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Parses a string to the specified enum type.
        /// </summary>
        /// <typeparam name="T">The enum type to parse to.</typeparam>
        /// <param name="value">An instance of the enum type (used for type inference).</param>
        /// <param name="stringValue">The string value to parse.</param>
        /// <param name="ignoreCase">True to ignore case; false to consider case.</param>
        /// <returns>The enum value parsed from the string.</returns>
        public static T Parse<T>(this T value, string stringValue, bool ignoreCase = false) where T : System.Enum
        {
            return (T)System.Enum.Parse(typeof(T), stringValue, ignoreCase);
        }
    }
}