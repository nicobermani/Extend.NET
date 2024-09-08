namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Replaces the character at the specified index with a new character.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="index">The index of the character to replace.</param>
        /// <param name="newChar">The new character to insert.</param>
        /// <returns>A new string with the character replaced at the specified index.</returns>
        public static string ToReplaceAt(this string @this, int index, char newChar)
        {
            if (index < 0 || index >= @this.Length)
                throw new ArgumentOutOfRangeException(nameof(index));

            char[] chars = @this.ToCharArray();
            chars[index] = newChar;
            return new string(chars);
        }
    }
}