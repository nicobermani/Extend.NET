namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Applies ROT13 encoding to the string.
        /// </summary>
        /// <param name="this">The string to encode.</param>
        /// <returns>The ROT13 encoded string.</returns>
        public static string ToRot13(this string @this)
        {
            return new string(@this.Select(c => {
                if (!char.IsLetter(c)) return c;
                char offset = char.IsUpper(c) ? 'A' : 'a';
                return (char)((((c + 13) - offset) % 26) + offset);
            }).ToArray());
        }
    }
}