namespace Extend.NET.String
{
    using System.Web;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Encodes the string for use in a URL.
        /// </summary>
        /// <param name="this">The string to encode.</param>
        /// <returns>The URL-encoded string.</returns>
        public static string ToUrlEncoded(this string @this)
        {
            return HttpUtility.UrlEncode(@this);
        }
    }
}