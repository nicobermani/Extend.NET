namespace Extend.NET.Dictionary
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// Returns all keys from the dictionary where the value satisfies the specified predicate.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary to search.</param>
        /// <param name="predicate">The predicate to apply to the values.</param>
        /// <returns>An IEnumerable of keys where the corresponding value satisfies the predicate.</returns>
        public static IEnumerable<TKey> GetKeysWhere<TKey, TValue>(
            this IDictionary<TKey, TValue> dictionary,
            Func<TValue, bool> predicate)
        {
            return dictionary
                .Where(kvp => predicate(kvp.Value))
                .Select(kvp => kvp.Key);
        }
    }
}