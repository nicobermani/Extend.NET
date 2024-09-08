namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Alternates the case of each character in the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>A new string with alternating case.</returns>
        public static string ToAlternateCase(this string @this)
        {
            char[] result = new char[@this.Length];
            bool upperCase = true;

            for (int i = 0; i < @this.Length; i++)
            {
                result[i] = upperCase ? char.ToUpper(@this[i]) : char.ToLower(@this[i]);
                if (char.IsLetter(@this[i]))
                    upperCase = !upperCase;
            }

            return new string(result);
        }
    }
}