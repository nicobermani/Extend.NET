using System.IO;
using System.Text;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file is likely to be binary (non-text) based on its content.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file is likely binary, false otherwise.</returns>
    public static bool IsFileBinary(this FileInfo file)
    {
        const int requiredConsecutiveNul = 1;
        const int charsToCheck = 8000;
        int nulCount = 0;

        using (var stream = file.OpenRead())
        {
            for (var i = 0; i < charsToCheck; i++)
            {
                if (stream.ReadByte() == 0)
                {
                    nulCount++;
                    if (nulCount >= requiredConsecutiveNul)
                    {
                        return true;
                    }
                }
                else
                {
                    nulCount = 0;
                }
            }
        }

        return false;
    }
}