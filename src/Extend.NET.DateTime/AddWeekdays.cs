using System;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Adds the specified number of weekdays (Monday to Friday) to the given date.
    /// </summary>
    /// <param name="date">The starting date.</param>
    /// <param name="days">The number of weekdays to add.</param>
    /// <returns>A new DateTime that is the specified number of weekdays after the input date.</returns>
    public static DateTime AddWeekdays(this DateTime date, int days)
    {
        var sign = Math.Sign(days);
        var unsignedDays = Math.Abs(days);
        var result = date;

        while (unsignedDays > 0)
        {
            result = result.AddDays(sign);
            if (result.DayOfWeek != DayOfWeek.Saturday && result.DayOfWeek != DayOfWeek.Sunday)
            {
                unsignedDays--;
            }
        }

        return result;
    }
}