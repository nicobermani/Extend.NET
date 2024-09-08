namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes the first occurrence of the specified string from the source string.
        /// </summary>
        /// <param name="this">The source string.</param>
        /// <param name="removeString">The string to remove.</param>
        /// <returns>A new string with the first occurrence of the specified string removed.</returns>
        public static string RemoveFirst(this string @this, string removeString)
        {
            var index = @this.IndexOf(removeString);
            return index < 0 ? @this : @this.Remove(index, removeString.Length);
        }
    }
}