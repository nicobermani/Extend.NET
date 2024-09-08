namespace Extend.NET.String
{
    using System.Text;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Expands tab characters in the string to spaces.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="tabSize">The number of spaces to replace each tab with.</param>
        /// <returns>The string with tabs expanded to spaces.</returns>
        public static string ToExpandTabs(this string @this, int tabSize = 4)
        {
            if (string.IsNullOrEmpty(@this) || tabSize <= 0)
                return @this;

            StringBuilder sb = new StringBuilder();
            int column = 0;

            foreach (char c in @this)
            {
                if (c == '\t')
                {
                    int spaces = tabSize - (column % tabSize);
                    sb.Append(new string(' ', spaces));
                    column += spaces;
                }
                else
                {
                    sb.Append(c);
                    if (c == '\n' || c == '\r')
                        column = 0;
                    else
                        column++;
                }
            }

            return sb.ToString();
        }
    }
}