namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Reverses the characters in the string.
        /// </summary>
        /// <param name="str">The string to reverse.</param>
        /// <returns>The reversed string.</returns>
        public static string Reverse(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            return new string(str.ToCharArray().Reverse().ToArray());
        }
    }
}