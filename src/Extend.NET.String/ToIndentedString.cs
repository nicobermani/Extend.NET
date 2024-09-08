namespace Extend.NET.String
{
    using System.Text;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Indents each line of the string by a specified number of spaces.
        /// </summary>
        /// <param name="this">The string to indent.</param>
        /// <param name="indentSize">The number of spaces to use for indentation.</param>
        /// <returns>The indented string.</returns>
        public static string ToIndentedString(this string @this, int indentSize = 4)
        {
            if (string.IsNullOrEmpty(@this)) return @this;

            var lines = @this.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            var sb = new StringBuilder();
            var indent = new string(' ', indentSize);

            foreach (var line in lines)
            {
                sb.AppendLine(indent + line);
            }

            return sb.ToString().TrimEnd();
        }
    }
}