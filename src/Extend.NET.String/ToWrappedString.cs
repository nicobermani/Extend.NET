namespace Extend.NET.String
{
    using System.Text;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Wraps the string to a specified width.
        /// </summary>
        /// <param name="this">The string to wrap.</param>
        /// <param name="width">The maximum width of each line.</param>
        /// <returns>The wrapped string.</returns>
        public static string ToWrappedString(this string @this, int width)
        {
            if (string.IsNullOrEmpty(@this) || width <= 0)
                return @this;

            StringBuilder sb = new StringBuilder();
            int currentLinePosition = 0;

            foreach (string word in @this.Split(' '))
            {
                if (currentLinePosition + word.Length > width)
                {
                    sb.AppendLine();
                    currentLinePosition = 0;
                }

                if (currentLinePosition > 0)
                {
                    sb.Append(' ');
                    currentLinePosition++;
                }

                sb.Append(word);
                currentLinePosition += word.Length;
            }

            return sb.ToString();
        }
    }
}