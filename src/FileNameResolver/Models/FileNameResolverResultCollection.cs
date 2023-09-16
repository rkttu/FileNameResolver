using System.Collections.ObjectModel;

namespace FileNameResolver.Models
{
    public sealed class FileNameResolverResultCollection : KeyedCollection<string, FileNameResolverResult>
    {
        protected override string GetKeyForItem(FileNameResolverResult item)
            => item.FullPath;
    }
}
