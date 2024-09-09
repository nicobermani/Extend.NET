using System.Collections;

namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Creates a thread-safe read-only wrapper for the current dictionary.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to wrap.</param>
    /// <returns>A thread-safe read-only dictionary wrapper.</returns>
    public static IReadOnlyDictionary<TKey, TValue> ToReadOnlyDictionaryThreadSafe<TKey, TValue>(
        this IDictionary<TKey, TValue> dictionary)
    {
        return new ReadOnlyDictionaryThreadSafe<TKey, TValue>(dictionary);
    }
}

internal class ReadOnlyDictionaryThreadSafe<TKey, TValue> : IReadOnlyDictionary<TKey, TValue>
{
    private readonly IDictionary<TKey, TValue> _dictionary;
    private readonly ReaderWriterLockSlim _lock = new();

    public ReadOnlyDictionaryThreadSafe(IDictionary<TKey, TValue> dictionary)
    {
        _dictionary = dictionary ?? throw new ArgumentNullException(nameof(dictionary));
    }

    public TValue this[TKey key]
    {
        get
        {
            _lock.EnterReadLock();
            try
            {
                return _dictionary[key];
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }
    }

    public IEnumerable<TKey> Keys
    {
        get
        {
            _lock.EnterReadLock();
            try
            {
                return _dictionary.Keys.ToList();
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }
    }

    public IEnumerable<TValue> Values
    {
        get
        {
            _lock.EnterReadLock();
            try
            {
                return _dictionary.Values.ToList();
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }
    }

    public int Count
    {
        get
        {
            _lock.EnterReadLock();
            try
            {
                return _dictionary.Count;
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }
    }

    public bool ContainsKey(TKey key)
    {
        _lock.EnterReadLock();
        try
        {
            return _dictionary.ContainsKey(key);
        }
        finally
        {
            _lock.ExitReadLock();
        }
    }

    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        _lock.EnterReadLock();
        try
        {
            return _dictionary.ToList().GetEnumerator();
        }
        finally
        {
            _lock.ExitReadLock();
        }
    }

    public bool TryGetValue(TKey key, out TValue value)
    {
        _lock.EnterReadLock();
        try
        {
            return _dictionary.TryGetValue(key, out value);
        }
        finally
        {
            _lock.ExitReadLock();
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}