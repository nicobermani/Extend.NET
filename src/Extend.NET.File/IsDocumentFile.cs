namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Checks if the file is a document file based on its extension.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>True if the file is a document file, false otherwise.</returns>
    public static bool IsDocumentFile(this FileInfo file)
    {
        string[] documentExtensions = { ".doc", ".docx", ".pdf", ".txt", ".rtf", ".odt", ".xls", ".xlsx", ".ppt", ".pptx" };
        return documentExtensions.Contains(file.Extension.ToLower());
    }
}