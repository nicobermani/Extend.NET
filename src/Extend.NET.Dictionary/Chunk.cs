namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Splits the dictionary into smaller dictionaries of the specified size.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to split.</param>
    /// <param name="chunkSize">The maximum number of elements in each chunk.</param>
    /// <returns>An enumerable of dictionaries, each containing at most the specified number of elements.</returns>
    public static IEnumerable<Dictionary<TKey, TValue>> Chunk<TKey, TValue>(this IDictionary<TKey, TValue> dictionary,
        int chunkSize)
    {
        if (chunkSize <= 0)
            throw new ArgumentException("Chunk size must be greater than zero.", nameof(chunkSize));

        return dictionary
            .Select((kvp, index) => new {kvp, index})
            .GroupBy(x => x.index / chunkSize)
            .Select(g => g.ToDictionary(x => x.kvp.Key, x => x.kvp.Value));
    }
}