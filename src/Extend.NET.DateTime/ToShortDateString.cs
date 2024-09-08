using System;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Converts the given DateTime to a short date string in the format "yyyy-MM-dd".
    /// </summary>
    /// <param name="date">The date to convert.</param>
    /// <returns>A short date string representation of the date.</returns>
    public static string ToShortDateString(this DateTime date)
    {
        return date.ToString("yyyy-MM-dd");
    }
}