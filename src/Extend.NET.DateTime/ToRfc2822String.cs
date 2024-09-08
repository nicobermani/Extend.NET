using System;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Converts the given DateTime to an RFC 2822 formatted string.
    /// </summary>
    /// <param name="date">The date to convert.</param>
    /// <returns>An RFC 2822 formatted string representation of the date.</returns>
    public static string ToRfc2822String(this DateTime date)
    {
        return date.ToString("ddd, dd MMM yyyy HH:mm:ss zzz");
    }
}