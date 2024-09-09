namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Adds a key/value pair to the dictionary if the key does not exist, or updates the value if the key already exists.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to modify.</param>
    /// <param name="key">The key to add or update.</param>
    /// <param name="addValue">The value to add if the key does not exist.</param>
    /// <param name="updateValueFactory">A function to generate a new value for an existing key based on the existing value.</param>
    /// <returns>The new value for the key.</returns>
    public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue addValue, Func<TKey, TValue, TValue> updateValueFactory)
    {
        if (dictionary.TryGetValue(key, out var existingValue))
        {
            var newValue = updateValueFactory(key, existingValue);
            dictionary[key] = newValue;
            return newValue;
        }
        else
        {
            dictionary[key] = addValue;
            return addValue;
        }
    }
}