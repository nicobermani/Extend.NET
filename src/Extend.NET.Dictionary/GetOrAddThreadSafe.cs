namespace Extend.NET.Dictionary
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// Gets the value associated with the specified key or adds a new value if the key does not exist.
        /// This method is thread-safe for concurrent access.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary to modify.</param>
        /// <param name="key">The key of the value to get or add.</param>
        /// <param name="valueFactory">The function used to generate a value for the key if it doesn't exist.</param>
        /// <returns>The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value if the key was not in the dictionary.</returns>
        public static TValue GetOrAddThreadSafe<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TKey, TValue> valueFactory)
        {
            if (dictionary.TryGetValue(key, out var value))
            {
                return value;
            }

            lock (dictionary)
            {
                if (dictionary.TryGetValue(key, out value))
                {
                    return value;
                }

                value = valueFactory(key);
                dictionary[key] = value;
                return value;
            }
        }
    }
}