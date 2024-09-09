namespace Extend.NET.Dictionary
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// Attempts to get the value associated with the specified key, or adds a new value if the key does not exist.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary to modify.</param>
        /// <param name="key">The key of the value to get or add.</param>
        /// <param name="valueFactory">The function used to generate a value for the key if it doesn't exist.</param>
        /// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the value parameter.</param>
        /// <returns>true if the key already exists in the dictionary; otherwise, false.</returns>
        public static bool TryGetValueOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TKey, TValue> valueFactory, out TValue value)
        {
            if (dictionary.TryGetValue(key, out value))
            {
                return true;
            }

            value = valueFactory(key);
            dictionary[key] = value;
            return false;
        }
    }
}