namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Renames a key in the dictionary while preserving its value.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to modify.</param>
    /// <param name="oldKey">The key to be renamed.</param>
    /// <param name="newKey">The new key name.</param>
    /// <returns>True if the key was successfully renamed; otherwise, false.</returns>
    public static bool RenameKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey oldKey, TKey newKey)
    {
        if (!dictionary.TryGetValue(oldKey, out var value))
            return false;

        dictionary.Remove(oldKey);
        dictionary[newKey] = value;
        return true;
    }
}