namespace Extend.NET.String
{
    using System.Collections.Generic;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Checks if the string has balanced parentheses.
        /// </summary>
        /// <param name="this">The string to check.</param>
        /// <returns>True if the parentheses are balanced; otherwise, false.</returns>
        public static bool ToIsBalancedParentheses(this string @this)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in @this)
            {
                if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    if (stack.Count == 0 || stack.Pop() != '(')
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}