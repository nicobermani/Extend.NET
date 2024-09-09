namespace Extend.NET.Dictionary
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// Converts the dictionary to a SortedDictionary.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary to convert.</param>
        /// <param name="comparer">The IComparer<TKey> implementation to use when comparing keys, or null to use the default comparer for the type of the key.</param>
        /// <returns>A new SortedDictionary containing all key-value pairs from the original dictionary.</returns>
        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, IComparer<TKey> comparer = null)
        {
            return new SortedDictionary<TKey, TValue>(dictionary, comparer);
        }
    }
}