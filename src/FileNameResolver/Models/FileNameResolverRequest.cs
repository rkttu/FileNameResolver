using System.Collections.Generic;
using System.Text;

namespace FileNameResolver.Models
{
    public sealed class FileNameResolverRequest
    {
        public FileNameResolverRequest(
            IEnumerable<string> targetPathList,
            NormalizationForm targetForm,
            bool removeZoneIdentifier)
        {
            TargetPathList = targetPathList;
            TargetForm = targetForm;
            RemoveZoneIdentifier = removeZoneIdentifier;
        }

        public IEnumerable<string> TargetPathList { get; private set; }

        public NormalizationForm TargetForm { get; private set; }

        public bool RemoveZoneIdentifier { get; private set; }
    }
}
