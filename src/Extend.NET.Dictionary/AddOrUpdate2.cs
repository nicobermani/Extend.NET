namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Adds a key/value pair to the dictionary if the key does not exist, or updates an existing key/value pair by using the specified function.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to modify.</param>
    /// <param name="key">The key to be added or updated.</param>
    /// <param name="addValue">The value to be added for an absent key.</param>
    /// <param name="updateValueFactory">The function used to generate a new value for an existing key based on the key's existing value.</param>
    /// <returns>The new value for the key.</returns>
    public static TValue AddOrUpdate2<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key,
        TValue addValue, Func<TKey, TValue, TValue> updateValueFactory)
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