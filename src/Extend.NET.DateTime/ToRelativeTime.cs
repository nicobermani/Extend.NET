namespace Extend.NET.DateTime;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Converts the given date to a relative time string (e.g., "2 days ago", "in 3 hours").
    /// </summary>
    /// <param name="date">The date to convert.</param>
    /// <returns>A string representing the relative time.</returns>
    public static string ToRelativeTime(this System.DateTime date)
    {
        var now = System.DateTime.Now;
        var diff = now - date;

        if (diff.TotalDays > 365)
            return $"{(int)(diff.TotalDays / 365)} year{((int)(diff.TotalDays / 365) == 1 ? "" : "s")} ago";
        if (diff.TotalDays > 30)
            return $"{(int)(diff.TotalDays / 30)} month{((int)(diff.TotalDays / 30) == 1 ? "" : "s")} ago";
        if (diff.TotalDays > 0)
            return $"{(int)diff.TotalDays} day{((int)diff.TotalDays == 1 ? "" : "s")} ago";
        if (diff.TotalHours > 0)
            return $"{(int)diff.TotalHours} hour{((int)diff.TotalHours == 1 ? "" : "s")} ago";
        if (diff.TotalMinutes > 0)
            return $"{(int)diff.TotalMinutes} minute{((int)diff.TotalMinutes == 1 ? "" : "s")} ago";

        return "just now";
    }
}