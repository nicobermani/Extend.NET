using System;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Converts the given DateTime to an ISO 8601 formatted string.
    /// </summary>
    /// <param name="date">The date to convert.</param>
    /// <returns>An ISO 8601 formatted string representation of the date.</returns>
    public static string ToIso8601String(this DateTime date)
    {
        return date.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
    }
}