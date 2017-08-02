namespace DestinySharp.Core.Entities
{
    public enum DestinyTalentNodeState
    {
        Invalid,
        CanUpgrade,
        NoPoints,
        NoPrerequisites,
        NoSteps,
        NoUnlock,
        NoMaterial,
        NoGridLevel,
        SwappingLocked,
        MustSwap,
        Complete,
        Unknown,
        CreationOnly,
        Hidden
    }
}
