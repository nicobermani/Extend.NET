using System;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Adds the specified number of business days to the given date.
    /// </summary>
    /// <param name="date">The starting date.</param>
    /// <param name="days">The number of business days to add.</param>
    /// <returns>A new DateTime that is the specified number of business days after the input date.</returns>
    public static DateTime AddBusinessDays(this DateTime date, int days)
    {
        if (days == 0) return date;

        if (days > 0)
        {
            int weeks = days / 5;
            int remainingDays = days % 5;
            date = date.AddDays(weeks * 7);

            for (int i = 0; i < remainingDays; i++)
            {
                date = date.AddDays(1);
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    remainingDays++;
            }
        }
        else
        {
            int weeks = Math.Abs(days) / 5;
            int remainingDays = Math.Abs(days) % 5;
            date = date.AddDays(weeks * -7);

            for (int i = 0; i < remainingDays; i++)
            {
                date = date.AddDays(-1);
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    remainingDays++;
            }
        }

        return date;
    }
}