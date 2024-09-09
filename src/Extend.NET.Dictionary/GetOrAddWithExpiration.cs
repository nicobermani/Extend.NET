namespace Extend.NET.Dictionary
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// Gets the value associated with the specified key or adds a new value with expiration if the key does not exist.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary to modify.</param>
        /// <param name="key">The key of the value to get or add.</param>
        /// <param name="valueFactory">The function used to generate a value for the key if it doesn't exist.</param>
        /// <param name="expirationTime">The time after which the added value should expire.</param>
        /// <returns>The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value if the key was not in the dictionary.</returns>
        public static TValue GetOrAddWithExpiration<TKey, TValue>(
            this IDictionary<TKey, Tuple<TValue, DateTime>> dictionary,
            TKey key,
            Func<TKey, TValue> valueFactory,
            TimeSpan expirationTime)
        {
            if (dictionary.TryGetValue(key, out var tuple))
            {
                if (DateTime.UtcNow < tuple.Item2)
                {
                    return tuple.Item1;
                }
            }

            var value = valueFactory(key);
            var expirationDateTime = DateTime.UtcNow.Add(expirationTime);
            dictionary[key] = Tuple.Create(value, expirationDateTime);
            return value;
        }
    }
}