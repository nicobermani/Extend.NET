using System.Collections.Specialized;
using System.ComponentModel;

namespace Extend.NET.Dictionary
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// Converts the dictionary to an ObservableDictionary.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary to convert.</param>
        /// <returns>An ObservableDictionary containing all key-value pairs from the original dictionary.</returns>
        public static ObservableDictionary<TKey, TValue> ToObservableDictionary<TKey, TValue>(
            this IDictionary<TKey, TValue> dictionary)
        {
            return new ObservableDictionary<TKey, TValue>(dictionary);
        }
    }

    public class ObservableDictionary<TKey, TValue> : IDictionary<TKey, TValue>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        private readonly Dictionary<TKey, TValue> _dictionary;

        public ObservableDictionary()
        {
            _dictionary = new Dictionary<TKey, TValue>();
        }

        public ObservableDictionary(IDictionary<TKey, TValue> dictionary)
        {
            _dictionary = new Dictionary<TKey, TValue>(dictionary);
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        public void Add(TKey key, TValue value)
        {
            _dictionary.Add(key, value);
            OnCollectionChanged(NotifyCollectionChangedAction.Add, new KeyValuePair<TKey, TValue>(key, value));
            OnPropertyChanged(nameof(Count));
        }

        public bool Remove(TKey key)
        {
            if (_dictionary.TryGetValue(key, out var value))
            {
                _dictionary.Remove(key);
                OnCollectionChanged(NotifyCollectionChangedAction.Remove, new KeyValuePair<TKey, TValue>(key, value));
                OnPropertyChanged(nameof(Count));
                return true;
            }
            return false;
        }

        public TValue this[TKey key]
        {
            get => _dictionary[key];
            set
            {
                var oldValue = _dictionary.ContainsKey(key) ? _dictionary[key] : default;
                _dictionary[key] = value;
                OnCollectionChanged(NotifyCollectionChangedAction.Replace, new KeyValuePair<TKey, TValue>(key, value), new KeyValuePair<TKey, TValue>(key, oldValue));
            }
        }

        public void Clear()
        {
            _dictionary.Clear();
            OnCollectionChanged(NotifyCollectionChangedAction.Reset);
            OnPropertyChanged(nameof(Count));
        }

        public bool ContainsKey(TKey key) => _dictionary.ContainsKey(key);

        public bool TryGetValue(TKey key, out TValue value) => _dictionary.TryGetValue(key, out value);

        public ICollection<TKey> Keys => _dictionary.Keys;

        public ICollection<TValue> Values => _dictionary.Values;

        public int Count => _dictionary.Count;

        public bool IsReadOnly => false;

        public void Add(KeyValuePair<TKey, TValue> item) => Add(item.Key, item.Value);

        public bool Contains(KeyValuePair<TKey, TValue> item) => _dictionary.Contains(item);

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) => ((IDictionary<TKey, TValue>)_dictionary).CopyTo(array, arrayIndex);

        public bool Remove(KeyValuePair<TKey, TValue> item) => Remove(item.Key);

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => _dictionary.GetEnumerator();

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();

        protected virtual void OnCollectionChanged(NotifyCollectionChangedAction action, KeyValuePair<TKey, TValue> newItem = default, KeyValuePair<TKey, TValue> oldItem = default)
        {
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(action, newItem, oldItem));
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}