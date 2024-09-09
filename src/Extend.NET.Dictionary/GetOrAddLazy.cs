namespace Extend.NET.Dictionary
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// Gets the value associated with the specified key or adds a new lazy-initialized value if the key does not exist.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary to modify.</param>
        /// <param name="key">The key of the value to get or add.</param>
        /// <param name="valueFactory">The function used to generate a value for the key.</param>
        /// <returns>The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new lazy-initialized value if the key was not in the dictionary.</returns>
        public static TValue GetOrAddLazy<TKey, TValue>(this IDictionary<TKey, Lazy<TValue>> dictionary, TKey key, Func<TValue> valueFactory)
        {
            if (!dictionary.TryGetValue(key, out var lazyValue))
            {
                lazyValue = new Lazy<TValue>(valueFactory);
                dictionary[key] = lazyValue;
            }
            return lazyValue.Value;
        }
    }
}