namespace Extend.NET.Dictionary
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// Converts the dictionary to a default dictionary that returns a default value for missing keys.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary to convert.</param>
        /// <param name="defaultValueFactory">A function that produces a default value for any given key.</param>
        /// <returns>A new dictionary that returns a default value for missing keys.</returns>
        public static DefaultDictionary<TKey, TValue> ToDefaultDictionary<TKey, TValue>(
            this IDictionary<TKey, TValue> dictionary,
            Func<TKey, TValue> defaultValueFactory)
        {
            return new DefaultDictionary<TKey, TValue>(dictionary, defaultValueFactory);
        }
    }

    public class DefaultDictionary<TKey, TValue> : Dictionary<TKey, TValue>
    {
        private readonly Func<TKey, TValue> _defaultValueFactory;

        public DefaultDictionary(IDictionary<TKey, TValue> dictionary, Func<TKey, TValue> defaultValueFactory)
            : base(dictionary)
        {
            _defaultValueFactory = defaultValueFactory;
        }

        public new TValue this[TKey key]
        {
            get
            {
                if (!TryGetValue(key, out var value))
                {
                    value = _defaultValueFactory(key);
                    base[key] = value;
                }
                return value;
            }
            set => base[key] = value;
        }
    }
}