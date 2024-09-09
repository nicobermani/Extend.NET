namespace Extend.NET.Dictionary
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// Creates a frozen (immutable) copy of the dictionary.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary to convert.</param>
        /// <returns>A frozen dictionary containing the key/value pairs from the input dictionary.</returns>
        public static System.Collections.Frozen.FrozenDictionary<TKey, TValue> ToFrozenDictionary<TKey, TValue>(
            this IDictionary<TKey, TValue> dictionary)
            where TKey : notnull
        {
            return System.Collections.Frozen.FrozenDictionary.ToFrozenDictionary(dictionary);
        }
    }
}