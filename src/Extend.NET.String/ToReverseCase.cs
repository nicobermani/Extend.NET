namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Reverses the case of each character in the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>A new string with the case of each character reversed.</returns>
        public static string ToReverseCase(this string @this)
        {
            if (string.IsNullOrEmpty(@this))
                return @this;

            return new string(@this.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)).ToArray());
        }
    }
}