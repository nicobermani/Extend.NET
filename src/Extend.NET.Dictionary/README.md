# Extend.NET.Dictionary

Last Updated: 2024-09-09 17:49:36

## 📖 Overview

Extend.NET.Dictionary is part of the Extend.NET suite, providing a collection of powerful and easy-to-use extension methods for Dictionary types in .NET applications. These extensions aim to simplify common tasks and enhance developer productivity.



## 🧰 Extension Methods
#### AddOrUpdate

Adds a key/value pair to the dictionary if the key does not exist, or updates the value if the key already exists.
    

#### AddOrUpdate2

Adds a key/value pair to the dictionary if the key does not exist, or updates an existing key/value pair by using the specified function.
    

#### AddOrUpdateRange

Adds or updates a range of key/value pairs in the dictionary.
        

#### AddRange

Adds a range of key-value pairs to the dictionary.
    

#### TValue

Splits the dictionary into smaller dictionaries of the specified size.
    

#### TValue

Filters the dictionary based on a predicate applied to the keys.
    

#### FindKey

Finds the first key that matches the given predicate.
    

#### TValue

Flattens a nested dictionary into a single-level dictionary with compound keys.
    

#### ForEach

Performs the specified action on each key/value pair in the dictionary.
    

#### GetKeys

Returns all keys from the dictionary that have the specified value.
    

#### GetKeysWhere

Returns all keys from the dictionary where the value satisfies the specified predicate.
        

#### GetOrAdd

Gets the value associated with the specified key or adds a new value if the key does not exist.
    

#### Task

Gets the value associated with the specified key or adds a new value asynchronously if the key does not exist.
    

#### GetOrAddConcurrent

Gets the value associated with the specified key or adds a new value if the key does not exist.
        This method is thread-safe and uses a ConcurrentDictionary internally.
        

#### GetOrAddLazy

Gets the value associated with the specified key or adds a new lazy-initialized value if the key does not exist.
        

#### GetOrAddThreadSafe

Gets the value associated with the specified key or adds a new value if the key does not exist.
        This method is thread-safe for concurrent access.
        

#### GetOrAddWithDisposable

Gets the value associated with the specified key or adds a new value if the key does not exist.
        This method ensures proper disposal of old values when replacing them.
        

#### RemoveAndDispose

Removes and disposes the value associated with the specified key.
        

#### GetOrAddWithExpiration

Gets the value associated with the specified key or adds a new value with expiration if the key does not exist.
        

#### GetOrDefault

Gets the value associated with the specified key, or a default value if the key is not found.
    

#### GetOrThrow

Gets the value associated with the specified key, or throws an exception if the key is not found.
    

#### GetValueOrAdd

Gets the value associated with the specified key. If the key does not exist, adds a new key/value pair using the provided factory method.
    

#### Task

Gets the value associated with the specified key or adds a new value asynchronously if the key does not exist.
        This method is thread-safe for concurrent access.
        

#### Task

Gets the value associated with the specified key or adds a new value asynchronously if the key does not exist.
        This method is thread-safe for concurrent access and uses a SemaphoreSlim for better performance.
        

#### GetValueOrAddWithLock

Gets the value associated with the specified key or adds a new value if the key does not exist.
        This method uses a lock to ensure thread safety.
        

#### GetValueOrAddWithRetry

Gets the value associated with the specified key or adds a new value if the key does not exist.
        This method retries the operation if there's a conflict during concurrent access.
        

#### GetValueOrAddWithTimeout

Gets the value associated with the specified key or adds a new value if the key does not exist.
        This method includes a timeout for the value factory operation.
        

#### GetValueOrDefault

Gets the value associated with the specified key, or the default value of the type if the key is not found.
    

#### GetValueOrDefault2

Gets the value associated with the specified key, or a default value if the key is not found.
    

#### TKey

Creates a new dictionary with the keys and values swapped.
    

#### TResult

Creates a new dictionary by applying a transformation function to the values of the original dictionary.
    

#### Merge

Merges the specified dictionary into the current dictionary, overwriting existing keys.
    

#### TValue

Merges two dictionaries, keeping the values from the left dictionary in case of key conflicts.
    

#### TValue

Paginates the dictionary into smaller dictionaries of the specified page size.
    

#### RemoveAll

Removes all key-value pairs that satisfy the specified predicate from the dictionary.
    

#### RemoveAndGet

Removes the value with the specified key from the dictionary and returns it.
    

#### RemoveWhere

Removes all key-value pairs from the dictionary that satisfy the specified condition.
        

#### RenameKey

Renames a key in the dictionary while preserving its value.
    

#### SafeGet

Safely gets the value associated with the specified key, returning a Maybe type.
    

#### TKey

Creates a new dictionary with the keys and values swapped.
    If multiple keys map to the same value, only one arbitrary key-value pair is kept in the result.
    

#### TValue

Converts the dictionary to a case-insensitive dictionary.
        

#### TValue

Converts the dictionary to a default dictionary that returns a default value for missing keys.
        

#### TValue

Creates a frozen (immutable) copy of the dictionary.
        

#### TValue

Creates an immutable copy of the dictionary.
    

#### List

Converts a dictionary to a multi-value dictionary where each key can have multiple values.
    

#### TValue

Converts the dictionary to an ObservableDictionary.
        

#### ToOrderedDictionary

Converts the dictionary to an OrderedDictionary.
    

#### TValue

Creates a read-only wrapper for the current dictionary.
    

#### TValue

Creates a thread-safe read-only wrapper for the current dictionary.
    

#### TValue

Converts the dictionary to a serializable dictionary.
        

#### TValue

Converts the dictionary to a SortedDictionary.
        

#### TryAdd

Attempts to add the specified key and value to the dictionary.
    

#### TryGetValueOrAdd

Attempts to get the value associated with the specified key, or adds a new value if the key does not exist.
        

#### TValue

Attempts to get multiple values from the dictionary using the specified keys.
        

#### TryRemove

Attempts to remove and return the value with the specified key from the dictionary.
    

#### TryRemoveRange

Attempts to remove a range of keys from the dictionary.
        

#### TryUpdate

Attempts to update an existing key/value pair in the dictionary.
    


