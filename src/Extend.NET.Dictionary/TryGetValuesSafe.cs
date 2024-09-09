namespace Extend.NET.Dictionary
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// Attempts to get multiple values from the dictionary using the specified keys.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary to search.</param>
        /// <param name="keys">The keys to locate in the dictionary.</param>
        /// <returns>A dictionary containing the successfully retrieved key-value pairs.</returns>
        public static IDictionary<TKey, TValue> TryGetValuesSafe<TKey, TValue>(
            this IDictionary<TKey, TValue> dictionary,
            IEnumerable<TKey> keys)
        {
            var result = new Dictionary<TKey, TValue>();
            foreach (var key in keys)
            {
                if (dictionary.TryGetValue(key, out var value))
                {
                    result[key] = value;
                }
            }
            return result;
        }
    }
}