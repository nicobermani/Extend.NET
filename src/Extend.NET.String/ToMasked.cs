namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Masks a portion of the string with a specified character.
        /// </summary>
        /// <param name="this">The string to mask.</param>
        /// <param name="maskChar">The character to use for masking.</param>
        /// <param name="unmaskedStart">The number of characters to leave unmasked at the start.</param>
        /// <param name="unmaskedEnd">The number of characters to leave unmasked at the end.</param>
        /// <returns>The masked string.</returns>
        public static string ToMasked(this string @this, char maskChar = '*', int unmaskedStart = 0, int unmaskedEnd = 0)
        {
            if (string.IsNullOrEmpty(@this)) return @this;
            if (unmaskedStart + unmaskedEnd >= @this.Length) return @this;

            var maskedPart = new string(maskChar, @this.Length - unmaskedStart - unmaskedEnd);
            return @this.Substring(0, unmaskedStart) + maskedPart + @this.Substring(@this.Length - unmaskedEnd);
        }
    }
}