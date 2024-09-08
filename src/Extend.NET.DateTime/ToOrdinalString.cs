namespace Extend.NET.DateTime;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Converts the day of the month to its ordinal string representation.
    /// </summary>
    /// <param name="date">The date to convert.</param>
    /// <returns>The day of the month as an ordinal string (e.g., "1st", "2nd", "3rd", "4th").</returns>
    public static string ToOrdinalString(this System.DateTime date)
    {
        int day = date.Day;
        var suffix = day % 10 == 1 && day % 100 != 11 ? "st"
            : day % 10 == 2 && day % 100 != 12 ? "nd"
            : day % 10 == 3 && day % 100 != 13 ? "rd"
            : "th";
        return $"{day}{suffix}";
    }
}