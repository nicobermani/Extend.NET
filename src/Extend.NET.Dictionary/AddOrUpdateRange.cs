namespace Extend.NET.Dictionary
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// Adds or updates a range of key/value pairs in the dictionary.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary to modify.</param>
        /// <param name="keyValuePairs">The key/value pairs to add or update.</param>
        /// <param name="updateValueFactory">A function to generate a new value for an existing key based on the existing value.</param>
        public static void AddOrUpdateRange<TKey, TValue>(
            this IDictionary<TKey, TValue> dictionary,
            IEnumerable<KeyValuePair<TKey, TValue>> keyValuePairs,
            Func<TKey, TValue, TValue, TValue> updateValueFactory)
        {
            foreach (var kvp in keyValuePairs)
            {
                dictionary.AddOrUpdate(kvp.Key, kvp.Value, (key, existingValue) => updateValueFactory(key, existingValue, kvp.Value));
            }
        }
    }
}