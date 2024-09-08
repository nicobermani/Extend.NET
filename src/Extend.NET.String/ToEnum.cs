namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts the string to an enum value of type T.
        /// </summary>
        /// <typeparam name="T">The enum type to convert to.</typeparam>
        /// <param name="this">The string to convert.</param>
        /// <param name="ignoreCase">Whether to ignore case when parsing the enum.</param>
        /// <returns>The enum value.</returns>
        public static T ToEnum<T>(this string @this, bool ignoreCase = true) where T : struct
        {
            return (T)Enum.Parse(typeof(T), @this, ignoreCase);
        }
    }
}