using Content.Shared.Actions;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;

namespace Content.Shared.Silicons.Laws.Components;

/// <summary>
/// This is used for entities which are bound to silicon laws and can view them.
/// </summary>
[RegisterComponent, Access(typeof(SharedSiliconLawSystem))]
public sealed partial class SiliconLawBoundComponent : Component
{
    [DataField("showlaws")]
    public bool ShowLaws = true;

    /// <summary>
    /// The sidebar action that toggles the laws screen.
    /// </summary>
    [DataField]
    public EntProtoId ViewLawsAction = "ActionViewLaws";

    /// <summary>
    /// The action for toggling laws. Stored here so we can remove it later.
    /// </summary>
    [DataField]
    public EntityUid? ViewLawsActionEntity;

    /// <summary>
    /// The last entity that provided laws to this entity.
    /// </summary>
    [DataField]
    public EntityUid? LastLawProvider;
}

/// <summary>
/// Event raised to get the laws that a law-bound entity has.
///
/// Is first raised on the entity itself, then on the
/// entity's station, then on the entity's grid,
/// before being broadcast.
/// </summary>
/// <param name="Entity"></param>
[ByRefEvent]
public record struct GetSiliconLawsEvent(EntityUid Entity)
{
    public EntityUid Entity = Entity;

    public SiliconLawset Laws = new();

    public bool Handled = false;
}

public sealed partial class ToggleLawsScreenEvent : InstantActionEvent
{

}

[NetSerializable, Serializable]
public enum SiliconLawsUiKey : byte
{
    Key
}

[Serializable, NetSerializable]
public sealed class SiliconLawBuiState : BoundUserInterfaceState
{
    public List<SiliconLaw> Laws;
    public HashSet<string>? RadioChannels;

    public SiliconLawBuiState(List<SiliconLaw> laws, HashSet<string>? radioChannels)
    {
        Laws = laws;
        RadioChannels = radioChannels;
    }
}
