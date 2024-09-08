using System.Text;

namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Attempts to detect the encoding of a text file.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The detected Encoding, or UTF8 if detection fails.</returns>
    public static Encoding GetEncodingType(this FileInfo file)
    {
        using (var reader = new StreamReader(file.FullName, Encoding.ASCII, true))
        {
            reader.Peek(); // you need to read the file to get the encoding
            return reader.CurrentEncoding;
        }
    }
}