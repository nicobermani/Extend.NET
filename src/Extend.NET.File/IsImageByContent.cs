namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file is an image by examining its content.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file is an image, false otherwise.</returns>
    public static bool IsImageByContent(this FileInfo file)
    {
        var fileBytes = new byte[8];
        using (var fs = file.OpenRead())
        {
            fs.Read(fileBytes, 0, 8);
        }

        byte[][] imageHeaders = {
            new byte[] { 0xFF, 0xD8 },                   // JPEG
            new byte[] { 0x89, 0x50, 0x4E, 0x47 },       // PNG
            new byte[] { 0x47, 0x49, 0x46 },             // GIF
            new byte[] { 0x42, 0x4D },                   // BMP
            new byte[] { 0x49, 0x49, 0x2A, 0x00 },       // TIFF
            new byte[] { 0x4D, 0x4D, 0x00, 0x2A }        // TIFF
        };

        return imageHeaders.Any(header => fileBytes.Take(header.Length).SequenceEqual(header));
    }
}