using System.Globalization;

namespace Extend.NET.DateTime;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Gets the full name of the month for the given date.
    /// </summary>
    /// <param name="date">The date to get the month name for.</param>
    /// <returns>The full name of the month.</returns>
    public static string GetMonthName(this System.DateTime date)
    {
        return date.ToString("MMMM", CultureInfo.CurrentCulture);
    }
}