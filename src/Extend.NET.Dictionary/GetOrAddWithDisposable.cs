namespace Extend.NET.Dictionary
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// Gets the value associated with the specified key or adds a new value if the key does not exist.
        /// This method ensures proper disposal of old values when replacing them.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary to modify.</param>
        /// <param name="key">The key of the value to get or add.</param>
        /// <param name="valueFactory">The function used to generate a value for the key if it doesn't exist.</param>
        /// <returns>The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value if the key was not in the dictionary.</returns>
        public static TValue GetOrAddWithDisposable<TKey, TValue>(
            this IDictionary<TKey, TValue> dictionary,
            TKey key,
            Func<TKey, TValue> valueFactory) where TValue : IDisposable
        {
            if (dictionary.TryGetValue(key, out var existingValue))
            {
                return existingValue;
            }

            lock (dictionary)
            {
                if (dictionary.TryGetValue(key, out existingValue))
                {
                    return existingValue;
                }

                var newValue = valueFactory(key);
                dictionary[key] = newValue;
                return newValue;
            }
        }

        /// <summary>
        /// Removes and disposes the value associated with the specified key.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary to modify.</param>
        /// <param name="key">The key of the element to remove and dispose.</param>
        /// <returns>true if the element is successfully found and removed; otherwise, false.</returns>
        public static bool RemoveAndDispose<TKey, TValue>(
            this IDictionary<TKey, TValue> dictionary,
            TKey key) where TValue : IDisposable
        {
            if (dictionary.TryGetValue(key, out var value))
            {
                dictionary.Remove(key);
                value.Dispose();
                return true;
            }
            return false;
        }
    }

    public interface IDisposable<out T> : IDisposable
    {
        T Value { get; }
    }

    internal class DisposableWrapper<T> : IDisposable<T> where T : IDisposable
    {
        private readonly Action _onDispose;

        public DisposableWrapper(T value, Action onDispose)
        {
            Value = value;
            _onDispose = onDispose;
        }

        public T Value { get; }

        public void Dispose()
        {
            _onDispose();
        }
    }
}