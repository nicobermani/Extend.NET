namespace Extend.NET.DateTime;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Adds the specified number of business days to the given date.
    /// </summary>
    /// <param name="date">The starting date.</param>
    /// <param name="days">The number of business days to add.</param>
    /// <returns>A new DateTime that is the specified number of business days after the input date.</returns>
    public static System.DateTime AddBusinessDays(this System.DateTime date, int days)
    {
        if (days == 0) return date;

        if (days > 0)
        {
            var weeks = days / 5;
            var remainingDays = days % 5;
            date = date.AddDays(weeks * 7);

            for (var i = 0; i < remainingDays; i++)
            {
                date = date.AddDays(1);
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    remainingDays++;
            }
        }
        else
        {
            var weeks = Math.Abs(days) / 5;
            var remainingDays = Math.Abs(days) % 5;
            date = date.AddDays(weeks * -7);

            for (var i = 0; i < remainingDays; i++)
            {
                date = date.AddDays(-1);
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    remainingDays++;
            }
        }

        return date;
    }
}