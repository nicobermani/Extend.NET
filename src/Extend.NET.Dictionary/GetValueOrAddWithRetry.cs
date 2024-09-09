namespace Extend.NET.Dictionary
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// Gets the value associated with the specified key or adds a new value if the key does not exist.
        /// This method retries the operation if there's a conflict during concurrent access.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary to modify.</param>
        /// <param name="key">The key of the value to get or add.</param>
        /// <param name="valueFactory">The function used to generate a value for the key if it doesn't exist.</param>
        /// <param name="maxRetries">The maximum number of retries in case of conflicts.</param>
        /// <returns>The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value if the key was not in the dictionary.</returns>
        public static TValue GetValueOrAddWithRetry<TKey, TValue>(
            this IDictionary<TKey, TValue> dictionary,
            TKey key,
            Func<TKey, TValue> valueFactory,
            int maxRetries = 3)
        {
            for (int attempt = 0; attempt < maxRetries; attempt++)
            {
                if (dictionary.TryGetValue(key, out var existingValue))
                {
                    return existingValue;
                }

                var newValue = valueFactory(key);

                try
                {
                    dictionary.Add(key, newValue);
                    return newValue;
                }
                catch (ArgumentException)
                {
                    // Key was added by another thread, retry
                    if (attempt == maxRetries - 1)
                    {
                        // Last attempt, just return whatever is there now
                        return dictionary[key];
                    }
                }
            }

            throw new InvalidOperationException("Failed to add or retrieve value after maximum retries.");
        }
    }
}