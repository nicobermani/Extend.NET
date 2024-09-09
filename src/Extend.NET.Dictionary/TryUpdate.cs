namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Attempts to update an existing key/value pair in the dictionary.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to modify.</param>
    /// <param name="key">The key of the element to update.</param>
    /// <param name="newValue">The new value for the specified key.</param>
    /// <param name="comparisonValue">The value that is compared to the value of the element.</param>
    /// <returns>true if the value with the specified key was equal to comparisonValue and was replaced with newValue; otherwise, false.</returns>
    public static bool TryUpdate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue newValue,
        TValue comparisonValue)
    {
        if (dictionary.TryGetValue(key, out var existingValue) &&
            EqualityComparer<TValue>.Default.Equals(existingValue, comparisonValue))
        {
            dictionary[key] = newValue;
            return true;
        }

        return false;
    }
}