namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Creates a new dictionary with the keys and values swapped.
    /// If multiple keys map to the same value, only one arbitrary key-value pair is kept in the result.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the original dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the original dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to swap.</param>
    /// <returns>A new dictionary with keys and values swapped.</returns>
    public static Dictionary<TValue, TKey> SwapKeyValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
        where TValue : notnull
    {
        return dictionary.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);
    }
}