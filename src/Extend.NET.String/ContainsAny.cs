namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Determines whether the string contains any of the specified substrings.
        /// </summary>
        /// <param name="this">The string to search in.</param>
        /// <param name="values">The substrings to search for.</param>
        /// <returns>True if the string contains any of the specified substrings; otherwise, false.</returns>
        public static bool ContainsAny(this string @this, params string[] values)
        {
            foreach (string value in values)
            {
                if (@this.Contains(value))
                    return true;
            }
            return false;
        }
    }
}