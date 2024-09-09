namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Gets the value associated with the specified key, or a default value if the key is not found.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to search.</param>
    /// <param name="key">The key to locate in the dictionary.</param>
    /// <param name="defaultValueFactory">A function that produces a default value when the key is not found.</param>
    /// <returns>The value associated with the key if found; otherwise, the result of defaultValueFactory.</returns>
    public static TValue GetValueOrDefault2<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key,
        Func<TKey, TValue> defaultValueFactory)
    {
        return dictionary.TryGetValue(key, out var value) ? value : defaultValueFactory(key);
    }
}