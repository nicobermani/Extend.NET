namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Merges two dictionaries, keeping the values from the left dictionary in case of key conflicts.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionaries.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionaries.</typeparam>
    /// <param name="left">The left dictionary (values from this dictionary take precedence).</param>
    /// <param name="right">The right dictionary.</param>
    /// <returns>A new dictionary containing all key-value pairs from both dictionaries, with left values taking precedence in case of conflicts.</returns>
    public static Dictionary<TKey, TValue> MergeLeft<TKey, TValue>(this IDictionary<TKey, TValue> left,
        IDictionary<TKey, TValue> right)
    {
        var result = new Dictionary<TKey, TValue>(right);
        foreach (var kvp in left) result[kvp.Key] = kvp.Value;
        return result;
    }
}