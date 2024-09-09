namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Returns all keys from the dictionary that have the specified value.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to search.</param>
    /// <param name="value">The value to search for.</param>
    /// <returns>An IEnumerable of keys that have the specified value.</returns>
    public static IEnumerable<TKey> GetKeys<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TValue value)
    {
        return dictionary.Where(kvp => EqualityComparer<TValue>.Default.Equals(kvp.Value, value))
            .Select(kvp => kvp.Key);
    }
}