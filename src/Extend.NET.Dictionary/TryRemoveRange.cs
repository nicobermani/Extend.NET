namespace Extend.NET.Dictionary
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// Attempts to remove a range of keys from the dictionary.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary to modify.</param>
        /// <param name="keys">The collection of keys to remove.</param>
        /// <returns>The number of elements successfully removed from the dictionary.</returns>
        public static int TryRemoveRange<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, IEnumerable<TKey> keys)
        {
            int removedCount = 0;
            foreach (var key in keys)
            {
                if (dictionary.Remove(key))
                {
                    removedCount++;
                }
            }
            return removedCount;
        }
    }
}