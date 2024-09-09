namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Performs the specified action on each key/value pair in the dictionary.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to iterate over.</param>
    /// <param name="action">The action to perform on each key/value pair.</param>
    public static void ForEach<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, Action<TKey, TValue> action)
    {
        foreach (var kvp in dictionary)
        {
            action(kvp.Key, kvp.Value);
        }
    }
}