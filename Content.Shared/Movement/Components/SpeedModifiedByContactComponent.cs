using Robust.Shared.GameStates;

namespace Content.Shared.Movement.Components;

/// <summary>
/// Exists just to listen to a single event. What a life.
/// </summary>
[NetworkedComponent, RegisterComponent] // must be networked to properly predict adding & removal
public sealed partial class SpeedModifiedByContactComponent : Component
{
}
