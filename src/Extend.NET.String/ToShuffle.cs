namespace Extend.NET.String
{
    using System;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Shuffles the characters in the string randomly.
        /// </summary>
        /// <param name="this">The string to shuffle.</param>
        /// <returns>A new string with the characters shuffled randomly.</returns>
        public static string ToShuffle(this string @this)
        {
            char[] chars = @this.ToCharArray();
            Random random = new Random();
            
            for (int i = chars.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
            }

            return new string(chars);
        }
    }
}