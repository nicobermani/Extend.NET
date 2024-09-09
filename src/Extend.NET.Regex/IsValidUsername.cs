namespace Extend.NET.Regex
{
    public static partial class RegexExtensions
    {
        /// <summary>
        /// Determines whether the input string is a valid username.
        /// Valid usernames contain only alphanumeric characters, underscores, and hyphens,
        /// and are between 3 and 20 characters long.
        /// </summary>
        /// <param name="input">The string to check.</param>
        /// <returns>True if the input is a valid username; otherwise, false.</returns>
        public static bool IsValidUsername(this string input)
        {
            string pattern = @"^[a-zA-Z0-9_-]{3,20}$";
            return System.Text.RegularExpressions.Regex.IsMatch(input, pattern);
        }
    }
}