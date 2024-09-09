namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Merges the specified dictionary into the current dictionary, overwriting existing keys.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to merge into.</param>
    /// <param name="other">The dictionary to merge from.</param>
    public static void Merge<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, IDictionary<TKey, TValue> other)
    {
        foreach (var kvp in other)
        {
            dictionary[kvp.Key] = kvp.Value;
        }
    }
}