namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Converts a dictionary to a multi-value dictionary where each key can have multiple values.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to convert.</param>
    /// <returns>A new dictionary where each key is associated with a list of values.</returns>
    public static Dictionary<TKey, List<TValue>> ToMultiValueDictionary<TKey, TValue>(
        this IDictionary<TKey, TValue> dictionary)
    {
        return dictionary.GroupBy(kvp => kvp.Key)
            .ToDictionary(g => g.Key, g => g.Select(kvp => kvp.Value).ToList());
    }
}