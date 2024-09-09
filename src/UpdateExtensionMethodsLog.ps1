param(
    [string]$projectDir,
    [string]$logFile
)

# Change log file to README.md in the project directory
$readmeFile = Join-Path $projectDir "README.md"

Write-Host "Project Directory: $projectDir"
Write-Host "README File: $readmeFile"

# Get all .cs files in the project directory
$files = Get-ChildItem -Path $projectDir -Filter *.cs -Recurse

Write-Host "Found $($files.Count) .cs files"

# Extract package name from directory name
$packageName = (Get-Item $projectDir).Name

# Generate README content
$timestamp = Get-Date -Format "yyyy-MM-dd HH:mm:ss"
$readmeContent = @"
# $packageName

Last Updated: $timestamp

## 📖 Overview

$packageName is part of the Extend.NET suite, providing a collection of powerful and easy-to-use extension methods for $($packageName.Replace("Extend.NET.", "")) types in .NET applications. These extensions aim to simplify common tasks and enhance developer productivity.



## 🧰 Extension Methods

"@

foreach ($file in $files) {
    $content = Get-Content $file.FullName -Raw
    
    # Extract class name
    if ($content -match "public\s+static\s+partial\s+class\s+(\w+)") {
        $className = $matches[1]
    } else {
        $className = "Unknown"
    }
    
    # Extract method names and summaries
    $methods = [regex]::Matches($content, '///\s*<summary>([\s\S]*?)</summary>[\s\S]*?public\s+static\s+\S+\s+(\w+)')
    
    if ($methods.Count -gt 0) {
        
        foreach ($method in $methods) {
            $summary = $method.Groups[1].Value.Trim() -replace '///\s*', ''
            $methodName = $method.Groups[2].Value
            
            $readmeContent += "#### $methodName`n`n$summary`n`n"
        }
    }
}



# Update the README file
Set-Content -Path $readmeFile -Value $readmeContent

Write-Host "README.md updated with $($files.Count) files containing extension methods"