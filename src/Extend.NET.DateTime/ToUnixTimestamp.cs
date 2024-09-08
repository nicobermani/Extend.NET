namespace Extend.NET.DateTime;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Converts the given DateTime to a Unix timestamp (seconds since Unix epoch).
    /// </summary>
    /// <param name="date">The date to convert.</param>
    /// <returns>The number of seconds since the Unix epoch (January 1, 1970).</returns>
    public static long ToUnixTimestamp(this System.DateTime date)
    {
        return ((DateTimeOffset)date.ToUniversalTime()).ToUnixTimeSeconds();
    }
}