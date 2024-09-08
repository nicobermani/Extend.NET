using System.Security.Principal;

namespace Extend.NET.File;

public static partial class FileExtensions
{
    /// <summary>
    /// Gets the owner of the file.
    /// </summary>
    /// <param name="file">The FileInfo object representing the file.</param>
    /// <returns>The name of the file owner.</returns>
    public static string GetFileOwner(this FileInfo file)
    {
        var fs = file.GetAccessControl();
        var sid = fs.GetOwner(typeof(SecurityIdentifier));
        var ntAccount = sid.Translate(typeof(NTAccount));
        return ntAccount.Value;
    }
}