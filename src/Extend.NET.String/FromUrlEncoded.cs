namespace Extend.NET.String
{
    using System.Web;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Decodes a URL-encoded string.
        /// </summary>
        /// <param name="this">The URL-encoded string to decode.</param>
        /// <returns>The decoded string.</returns>
        public static string FromUrlEncoded(this string @this)
        {
            return HttpUtility.UrlDecode(@this);
        }
    }
}