namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Creates an immutable copy of the dictionary.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to convert.</param>
    /// <returns>An immutable dictionary containing the key/value pairs from the input dictionary.</returns>
    public static System.Collections.Immutable.ImmutableDictionary<TKey, TValue> ToImmutableDictionary<TKey, TValue>(
        this IDictionary<TKey, TValue> dictionary)
    {
        return System.Collections.Immutable.ImmutableDictionary.CreateRange(dictionary);
    }
}