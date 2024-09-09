namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Filters the dictionary based on a predicate applied to the keys.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to filter.</param>
    /// <param name="predicate">The predicate to apply to the keys.</param>
    /// <returns>A new dictionary containing only the key-value pairs where the key satisfies the predicate.</returns>
    public static Dictionary<TKey, TValue> FilterByKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary,
        Func<TKey, bool> predicate)
    {
        return dictionary
            .Where(kvp => predicate(kvp.Key))
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    }
}