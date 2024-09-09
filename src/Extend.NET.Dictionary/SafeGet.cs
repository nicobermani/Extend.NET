namespace Extend.NET.Dictionary;

public static partial class DictionaryExtensions
{
    /// <summary>
    /// Safely gets the value associated with the specified key, returning a Maybe type.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">The dictionary to search.</param>
    /// <param name="key">The key to locate in the dictionary.</param>
    /// <returns>A Maybe type containing the value if the key is found; otherwise, an empty Maybe.</returns>
    public static Maybe<TValue> SafeGet<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
    {
        return dictionary.TryGetValue(key, out var value) ? new Maybe<TValue>(value) : Maybe<TValue>.None;
    }
}

public struct Maybe<T>
{
    private readonly T _value;
    private readonly bool _hasValue;

    public Maybe(T value)
    {
        _value = value;
        _hasValue = true;
    }

    public static Maybe<T> None => new();

    public bool HasValue => _hasValue;

    public T Value => _hasValue ? _value : throw new InvalidOperationException("Maybe does not have a value.");

    public T ValueOrDefault(T defaultValue)
    {
        return _hasValue ? _value : defaultValue;
    }
}