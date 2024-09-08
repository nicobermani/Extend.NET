namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Reverses the characters in the string.
        /// </summary>
        /// <param name="this">The string to reverse.</param>
        /// <returns>A new string with the characters in reverse order.</returns>
        public static string Reverse(this string @this)
        {
            return new string(@this.ToCharArray().Reverse().ToArray());
        }
    }
}