namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Creates a new dictionary by applying a transformation function to the values of the original dictionary.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the original dictionary.</typeparam>
    /// <typeparam name="TResult">The type of the values in the resulting dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to transform.</param>
    /// <param name="valueSelector">The function to apply to each value.</param>
    /// <returns>A new dictionary with the same keys and transformed values.</returns>
    public static Dictionary<TKey, TResult> MapValues<TKey, TValue, TResult>(this IDictionary<TKey, TValue> dictionary,
        Func<TValue, TResult> valueSelector)
    {
        return dictionary.ToDictionary(
            kvp => kvp.Key,
            kvp => valueSelector(kvp.Value)
        );
    }
}