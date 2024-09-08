namespace Extend.NET.DateTime;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Returns the first day of the week for the given date.
    /// </summary>
    /// <param name="date">The date to get the start of the week for.</param>
    /// <param name="startOfWeek">The day considered as the start of the week (default is Sunday).</param>
    /// <returns>A new DateTime representing the first day of the week.</returns>
    public static System.DateTime StartOfWeek(this System.DateTime date, DayOfWeek startOfWeek = DayOfWeek.Sunday)
    {
        int diff = (7 + (date.DayOfWeek - startOfWeek)) % 7;
        return date.AddDays(-1 * diff).Date;
    }
}