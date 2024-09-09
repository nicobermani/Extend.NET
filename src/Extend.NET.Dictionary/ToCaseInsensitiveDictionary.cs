namespace Extend.NET.Dictionary
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// Converts the dictionary to a case-insensitive dictionary.
        /// </summary>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary to convert.</param>
        /// <returns>A new dictionary with case-insensitive string keys.</returns>
        public static Dictionary<string, TValue> ToCaseInsensitiveDictionary<TValue>(
            this IDictionary<string, TValue> dictionary)
        {
            return new Dictionary<string, TValue>(dictionary, StringComparer.OrdinalIgnoreCase);
        }
    }
}