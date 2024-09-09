namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Paginates the dictionary into smaller dictionaries of the specified page size.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to paginate.</param>
    /// <param name="pageSize">The maximum number of elements in each page.</param>
    /// <param name="pageNumber">The page number to retrieve (1-based).</param>
    /// <returns>A dictionary containing the specified page of key-value pairs.</returns>
    public static Dictionary<TKey, TValue> Paginate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary,
        int pageSize, int pageNumber)
    {
        if (pageSize <= 0)
            throw new ArgumentException("Page size must be greater than zero.", nameof(pageSize));
        if (pageNumber <= 0)
            throw new ArgumentException("Page number must be greater than zero.", nameof(pageNumber));

        return dictionary
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    }
}