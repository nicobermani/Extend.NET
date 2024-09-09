namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Removes all key-value pairs that satisfy the specified predicate from the dictionary.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to modify.</param>
    /// <param name="predicate">A function to test each key-value pair for a condition.</param>
    /// <returns>The number of elements removed from the dictionary.</returns>
    public static int RemoveAll<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, Func<TKey, TValue, bool> predicate)
    {
        var keysToRemove = dictionary.Where(kvp => predicate(kvp.Key, kvp.Value)).Select(kvp => kvp.Key).ToList();
        foreach (var key in keysToRemove)
        {
            dictionary.Remove(key);
        }
        return keysToRemove.Count;
    }
}