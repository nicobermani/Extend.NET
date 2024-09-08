using System.Globalization;

namespace Extend.NET.DateTime;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Gets the week of the year for the given date.
    /// </summary>
    /// <param name="date">The date to get the week of the year for.</param>
    /// <returns>The week of the year (1-53).</returns>
    public static int GetWeekOfYear(this System.DateTime date)
    {
        return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
            date,
            CultureInfo.CurrentCulture.DateTimeFormat.CalendarWeekRule,
            CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek);
    }
}