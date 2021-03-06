namespace Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Extensions;

    /// <summary>Resource tags.</summary>
    public partial class TrackedResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api10.ITrackedResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api10.ITrackedResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="TrackedResourceTags" /> instance.</summary>
        public TrackedResourceTags()
        {

        }
    }
    /// Resource tags.
    public partial interface ITrackedResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags.
    internal partial interface ITrackedResourceTagsInternal

    {

    }
}