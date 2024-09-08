using System.IO;
using System.Linq;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file is an audio file based on its extension.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file is an audio file, false otherwise.</returns>
    public static bool IsAudioFile(this FileInfo file)
    {
        string[] audioExtensions = { ".mp3", ".wav", ".ogg", ".flac", ".aac", ".wma", ".m4a" };
        return audioExtensions.Contains(file.Extension.ToLower());
    }
}