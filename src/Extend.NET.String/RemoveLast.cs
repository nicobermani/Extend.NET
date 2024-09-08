namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes the last occurrence of the specified string from the source string.
        /// </summary>
        /// <param name="this">The source string.</param>
        /// <param name="removeString">The string to remove.</param>
        /// <returns>A new string with the last occurrence of the specified string removed.</returns>
        public static string RemoveLast(this string @this, string removeString)
        {
            int index = @this.LastIndexOf(removeString);
            return index < 0 ? @this : @this.Remove(index, removeString.Length);
        }
    }
}