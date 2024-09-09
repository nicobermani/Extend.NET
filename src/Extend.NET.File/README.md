# Extend.NET.File

Last Updated: 2024-09-09 17:49:36

## 📖 Overview

Extend.NET.File is part of the Extend.NET suite, providing a collection of powerful and easy-to-use extension methods for File types in .NET applications. These extensions aim to simplify common tasks and enhance developer productivity.



## 🧰 Extension Methods
#### AppendText

Appends text to the file.
    

#### CopyTo

Copies the file to a new location, overwriting if the destination file already exists.
    

#### CountLines

Counts the number of lines in a text file.
    

#### Decrypt

Decrypts the file that was encrypted using Windows Encrypting File System (EFS).
    

#### Encrypt

Encrypts the file using Windows Encrypting File System (EFS).
    

#### GetAttributes

Gets the attributes of the file.
    

#### GetCreationTime

Gets the creation time of the file.
    

#### GetDirectoryName

Gets the directory name of the file.
    

#### GetEncodingType

Attempts to detect the encoding of a text file.
    

#### GetFileAgeInDays

Gets the age of the file in days based on its last write time.
    

#### GetFileContentAsBase64

Gets the content of the file as a Base64 encoded string.
    

#### GetFileCreationTimeLocal

Gets the creation time of the file in the local time zone.
    

#### GetFileCreationTimeUtc

Gets the creation time of the file in UTC.
    

#### GetFileExtensionLength

Gets the length of the file extension (including the dot).
    

#### GetFileExtensionUpperCase

Gets the file extension in uppercase, including the dot.
    

#### GetFileExtensionWithDot

Gets the file extension with the leading dot.
    

#### GetFileExtensionWithoutDot

Gets the file extension without the leading dot.
    

#### GetFileExtensionWithoutDotAndInvalidChars

Gets the file extension without the leading dot and any invalid characters.
    

#### GetFileExtensionWithoutDotLowerCase

Gets the file extension without the leading dot in lowercase.
    

#### GetFileExtensionWithoutDotUpperCase

Gets the file extension without the leading dot in uppercase.
    

#### GetFileNameWithoutConsecutiveSpaces

Gets the file name without consecutive spaces.
    

#### GetFileNameWithoutExtension

Gets the file name without the extension.
    

#### GetFileNameWithoutExtensionAndInvalidChars

Gets the file name without extension and any invalid characters.
    

#### GetFileNameWithoutExtensionAndSpaces

Gets the file name without extension and spaces.
    

#### GetFileNameWithoutExtensionLowerCase

Gets the file name without extension in lowercase.
    

#### GetFileNameWithoutExtensionUpperCase

Gets the file name without extension in uppercase.
    

#### GetFileNameWithoutInvalidChars

Gets the file name without any invalid characters.
    

#### GetFileNameWithoutInvalidCharsAndExtension

Gets the file name without invalid characters and extension.
    

#### GetFileNameWithoutInvalidCharsAndSpaces

Gets the file name without invalid characters and spaces.
    

#### GetFileNameWithoutInvalidCharsAndSpacesLowerCase

Gets the file name without invalid characters and spaces, converted to lowercase.
    

#### GetFileNameWithoutInvalidCharsUpperCase

Gets the file name without invalid characters in uppercase.
    

#### GetFileNameWithoutNumbers

Gets the file name without numbers and extension.
    

#### GetFileNameWithTimestamp

Gets the file name with a timestamp appended.
    

#### GetFileOwner

Gets the owner of the file.
    

#### GetFilePermissions

Gets the file permissions as a string.
    

#### GetFileSize

Gets the size of the file in bytes.
    

#### GetFileSizeFormatted

Gets the file size formatted as a human-readable string (e.g., "1.23 MB").
    

#### GetFileSizeInGigabytes

Gets the size of the file in gigabytes.
    

#### GetFileSizeInKilobytes

Gets the size of the file in kilobytes.
    

#### GetFileSizeInMegabytes

Gets the size of the file in megabytes.
    

#### GetFileSizeInTerabytes

Gets the size of the file in terabytes.
    

#### GetFileType

Gets the file type based on its extension.
    

#### GetFileVersion

Gets the file version information.
    

#### GetFirstLine

Gets the first line of a text file.
    

#### GetLastAccessTime

Gets the last access time of the file.
    

#### GetLastAccessTimeLocal

Gets the last access time of the file in the local time zone.
    

#### GetLastAccessTimeUtc

Gets the last access time of the file in UTC.
    

#### GetLastLine

Gets the last line of a text file.
    

#### GetLastWriteTime

Gets the last write time of the file.
    

#### GetLastWriteTimeLocal

Gets the last write time of the file in the local time zone.
    

#### GetLastWriteTimeUtc

Gets the last write time of the file in UTC.
    

#### GetMD5Hash

Calculates the MD5 hash of the file.
    

#### GetMimeType

Gets the MIME type of the file based on its extension.
    

#### GetRelativePath

Gets the relative path of this file to a specified directory.
    

#### GetSHA256Hash

Calculates the SHA256 hash of the file.
    

#### GetSymbolicLinkTarget

Gets the target of a symbolic link.
    

#### HasExtension

Checks if the file has an extension.
    

#### IsAccessible

Checks if the file is accessible for reading.
    

#### IsArchiveFile

Checks if the file is an archive file based on its extension.
    

#### IsAudioFile

Checks if the file is an audio file based on its extension.
    

#### IsCompressed

Checks if the file is compressed based on its extension.
    

#### IsDocumentFile

Checks if the file is a document file based on its extension.
    

#### IsEmpty

Checks if the file is empty (has zero bytes).
    

#### IsEmptyOrWhiteSpace

Checks if the file is empty or contains only whitespace characters.
    

#### IsExecutable

Checks if the file is an executable based on its extension.
    

#### IsFileBinary

Checks if the file is likely to be binary (non-text) based on its content.
    

#### IsFileInUse

Checks if the file is currently in use by another process.
    

#### IsFileNameAllCaps

Checks if the file name (without extension) is all uppercase.
    

#### IsFileNamePascalCase

Checks if the file name (without extension) is in PascalCase.
    

#### IsFileNameSameAsExtension

Checks if the file name (without extension) is the same as its extension.
    

#### IsFileNameTooLong

Checks if the file name is too long for the current file system.
    

#### IsFileNameValid

Checks if the file name is valid (doesn't contain invalid characters).
    

#### IsHidden

Checks if the file is hidden.
    

#### IsImage

Checks if the file is an image based on its extension.
    

#### IsImageByContent

Checks if the file is an image by examining its content.
    

#### IsLocked

Checks if the file is currently locked (in use by another process).
    

#### IsNewerThan

Checks if this file is newer than another file.
    

#### IsOlderThan

Checks if this file is older than a specified timespan.
    

#### IsReadableAndWritable

Checks if the file is both readable and writable.
    

#### IsReadOnly

Checks if the file is read-only.
    

#### IsSymbolicLink

Checks if the file is a symbolic link.
    

#### IsSystemFile

Checks if the file is a system file.
    

#### IsTemporaryFile

Checks if the file is likely to be a temporary file based on its extension.
    

#### IsText

Checks if the file is a text file based on its extension.
    

#### IsValidFileName

Checks if the given string is a valid file name.
    

#### IsVideoFile

Checks if the file is a video file based on its extension.
    

#### IsWithinSizeRange

Checks if the file size is within a specified range.
    

#### MakeHidden

Sets the file as hidden.
    

#### MakeReadOnly

Sets the file as read-only.
    

#### MakeVisible

Removes the hidden attribute from the file.
    

#### MakeWritable

Removes the read-only attribute from the file.
    

#### MoveTo

Moves the file to a new location, overwriting if the destination file already exists.
    

#### Rename

Renames the file.
    

#### SetAttributes

Sets the attributes of the file.
    

#### SetCreationTimeLocal

Sets the creation time of the file in the local time zone.
    

#### SetCreationTimeUtc

Sets the creation time of the file in UTC.
    

#### SetLastAccessTimeLocal

Sets the last access time of the file in the local time zone.
    

#### SetLastAccessTimeUtc

Sets the last access time of the file in UTC.
    

#### SetLastWriteTimeLocal

Sets the last write time of the file in the local time zone.
    

#### SetLastWriteTimeUtc

Sets the last write time of the file in UTC.
    

#### TruncateFile

Truncates the file to a specified length.
    


