namespace Extend.NET.String
{
    using System.Net;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Checks if the string is a valid IP address (IPv4 or IPv6).
        /// </summary>
        /// <param name="this">The string to check.</param>
        /// <returns>True if the string is a valid IP address; otherwise, false.</returns>
        public static bool IsValidIpAddress(this string @this)
        {
            return IPAddress.TryParse(@this, out _);
        }
    }
}