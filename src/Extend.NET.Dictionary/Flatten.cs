namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Flattens a nested dictionary into a single-level dictionary with compound keys.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">The nested dictionary to flatten.</param>
    /// <param name="separator">The separator used to join the compound keys.</param>
    /// <returns>A new dictionary with flattened key-value pairs.</returns>
    public static Dictionary<string, TValue> Flatten<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, string separator = ".")
    {
        var result = new Dictionary<string, TValue>();
        FlattenHelper(dictionary, result, "", separator);
        return result;
    }

    private static void FlattenHelper<TKey, TValue>(IDictionary<TKey, TValue> dict, Dictionary<string, TValue> result, string prefix, string separator)
    {
        foreach (var kvp in dict)
        {
            var newKey = string.IsNullOrEmpty(prefix) ? kvp.Key.ToString() : prefix + separator + kvp.Key;
            if (kvp.Value is IDictionary<TKey, TValue> nestedDict)
            {
                FlattenHelper(nestedDict, result, newKey, separator);
            }
            else
            {
                result[newKey] = kvp.Value;
            }
        }
    }
}