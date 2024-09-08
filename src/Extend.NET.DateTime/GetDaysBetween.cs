namespace Extend.NET.DateTime;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Calculates the number of days between two dates.
    /// </summary>
    /// <param name="startDate">The start date.</param>
    /// <param name="endDate">The end date.</param>
    /// <returns>The number of days between the two dates.</returns>
    public static int GetDaysBetween(this System.DateTime startDate, System.DateTime endDate)
    {
        return (int)(endDate.Date - startDate.Date).TotalDays;
    }
}