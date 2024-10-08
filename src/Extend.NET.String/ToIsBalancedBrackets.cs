namespace Extend.NET.String;

using System.Collections.Generic;

public static partial class StringExtensions
{
    /// <summary>
    /// Checks if the string has balanced brackets (parentheses, square brackets, and curly braces).
    /// </summary>
    /// <param name="this">The string to check.</param>
    /// <returns>True if the brackets are balanced; otherwise, false.</returns>
    public static bool ToIsBalancedBrackets(this string @this)
    {
        var stack = new Stack<char>();
        var bracketPairs = new Dictionary<char, char>
        {
            {')', '('},
            {']', '['},
            {'}', '{'}
        };

        foreach (var c in @this)
            if ("([{".Contains(c))
                stack.Push(c);
            else if (")]}".Contains(c))
                if (stack.Count == 0 || stack.Pop() != bracketPairs[c])
                    return false;

        return stack.Count == 0;
    }
}