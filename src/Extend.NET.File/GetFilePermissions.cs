using System.Security.AccessControl;
using System.Text;

namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the file permissions as a string.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>A string representation of the file permissions.</returns>
    public static string GetFilePermissions(this FileInfo file)
    {
        var fileSecurity = file.GetAccessControl();
        var rules = fileSecurity.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount));

        var permissions = new StringBuilder();
        foreach (FileSystemAccessRule rule in rules)
            permissions.AppendLine(
                $"Account: {rule.IdentityReference.Value}, Access: {rule.FileSystemRights}, Type: {rule.AccessControlType}");
        return permissions.ToString();
    }
}