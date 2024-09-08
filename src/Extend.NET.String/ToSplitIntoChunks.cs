namespace Extend.NET.String;

using System.Collections.Generic;

public static partial class StringExtensions
{
    /// <summary>
    /// Splits the string into chunks of a specified size.
    /// </summary>
    /// <param name="this">The string to split.</param>
    /// <param name="chunkSize">The size of each chunk.</param>
    /// <returns>An array of string chunks.</returns>
    public static string[] ToSplitIntoChunks(this string @this, int chunkSize)
    {
        if (string.IsNullOrEmpty(@this) || chunkSize <= 0)
            return new[] {@this};

        List<string> chunks = new();
        for (var i = 0; i < @this.Length; i += chunkSize)
            if (i + chunkSize <= @this.Length)
                chunks.Add(@this.Substring(i, chunkSize));
            else
                chunks.Add(@this.Substring(i));

        return chunks.ToArray();
    }
}