namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Converts the dictionary to an OrderedDictionary.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to convert.</param>
    /// <returns>An OrderedDictionary containing all key-value pairs from the original dictionary.</returns>
    public static System.Collections.Specialized.OrderedDictionary ToOrderedDictionary<TKey, TValue>(
        this IDictionary<TKey, TValue> dictionary)
    {
        var orderedDict = new System.Collections.Specialized.OrderedDictionary();
        foreach (var kvp in dictionary) orderedDict.Add(kvp.Key, kvp.Value);
        return orderedDict;
    }
}