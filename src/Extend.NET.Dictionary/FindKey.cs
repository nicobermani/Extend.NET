namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Finds the first key that matches the given predicate.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to search.</param>
    /// <param name="predicate">The predicate to match against the key-value pairs.</param>
    /// <returns>The first key that matches the predicate, or default(TKey) if no match is found.</returns>
    public static TKey FindKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary,
        Func<TKey, TValue, bool> predicate)
    {
        foreach (var kvp in dictionary)
            if (predicate(kvp.Key, kvp.Value))
                return kvp.Key;
        return default;
    }
}