namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Tries to parse a string to the specified enum type.
        /// </summary>
        /// <typeparam name="T">The enum type to parse to.</typeparam>
        /// <param name="value">An instance of the enum type (used for type inference).</param>
        /// <param name="stringValue">The string value to parse.</param>
        /// <param name="ignoreCase">True to ignore case; false to consider case.</param>
        /// <param name="result">When this method returns, contains the parsed enum value if the parse operation succeeded, or the default value of the enum type if the parse operation failed.</param>
        /// <returns>True if the parse operation succeeded; otherwise, false.</returns>
        public static bool TryParse<T>(this T value, string stringValue, bool ignoreCase, out T result) where T : struct, System.Enum
        {
            return System.Enum.TryParse(stringValue, ignoreCase, out result);
        }
    }
}