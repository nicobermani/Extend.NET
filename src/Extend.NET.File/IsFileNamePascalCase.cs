namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file name (without extension) is in PascalCase.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file name is in PascalCase, false otherwise.</returns>
    public static bool IsFileNamePascalCase(this FileInfo file)
    {
        var fileName = Path.GetFileNameWithoutExtension(file.Name);
        return char.IsUpper(fileName[0]) && fileName.Skip(1).Any(char.IsLower);
    }
}