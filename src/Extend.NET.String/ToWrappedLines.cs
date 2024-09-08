namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Wraps the string to a specified line length.
        /// </summary>
        /// <param name="this">The string to wrap.</param>
        /// <param name="lineLength">The maximum length of each line.</param>
        /// <returns>An array of wrapped lines.</returns>
        public static string[] ToWrappedLines(this string @this, int lineLength)
        {
            if (string.IsNullOrEmpty(@this) || lineLength <= 0)
                return new string[] { @this };

            List<string> lines = new List<string>();
            int currentPosition = 0;

            while (currentPosition < @this.Length)
            {
                int remainingLength = Math.Min(lineLength, @this.Length - currentPosition);
                int breakPosition = @this.LastIndexOf(' ', currentPosition + remainingLength - 1, remainingLength);

                if (breakPosition == -1 || breakPosition <= currentPosition)
                    breakPosition = currentPosition + remainingLength;

                lines.Add(@this.Substring(currentPosition, breakPosition - currentPosition).Trim());
                currentPosition = breakPosition + 1;
            }

            return lines.ToArray();
        }
    }
}