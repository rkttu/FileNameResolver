using System;

namespace FileNameResolver.Models
{
    public sealed class FileNameResolverResult
    {
        public FileNameResolverResult(string fullPath, bool isFile, bool isDirectory, FileNameResolverResultCategory category, Exception thrownException)
        {
            FullPath = fullPath;
            IsFile = isFile;
            IsDirectory = isDirectory;
            Category = category;
            ThrownException = thrownException;
        }
    
        public string FullPath { get; private set; }
        public bool IsFile { get; private set; }
        public bool IsDirectory { get; private set; }
        public FileNameResolverResultCategory Category { get; private set; }
        public Exception ThrownException { get; private set; }
    }
}
