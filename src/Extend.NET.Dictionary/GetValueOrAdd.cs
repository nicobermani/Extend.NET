namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Gets the value associated with the specified key. If the key does not exist, adds a new key/value pair using the provided factory method.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to search and potentially modify.</param>
    /// <param name="key">The key to locate in the dictionary.</param>
    /// <param name="valueFactory">A function that returns a new value to be added if the key is not found.</param>
    /// <returns>The value associated with the key, either existing or newly added.</returns>
    public static TValue GetValueOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TKey, TValue> valueFactory)
    {
        if (!dictionary.TryGetValue(key, out var value))
        {
            value = valueFactory(key);
            dictionary[key] = value;
        }
        return value;
    }
}