using System.Diagnostics.CodeAnalysis;
using Content.Shared.Players.PlayTimeTracking;
using Content.Shared.Roles;
using Robust.Shared.Player;
using Robust.Shared.Prototypes;
using Robust.Shared.Utility;

namespace Content.Shared.Preferences.Loadouts.Effects;

/// <summary>
/// Checks for a job requirement to be met such as playtime.
/// </summary>
public sealed partial class JobRequirementLoadoutEffect : LoadoutEffect
{
    [DataField(required: true)]
    public JobRequirement Requirement = default!;

    public override bool Validate(HumanoidCharacterProfile profile, RoleLoadout loadout, LoadoutPrototype proto, ICommonSession? session, IDependencyCollection collection, [NotNullWhen(false)] out FormattedMessage? reason)
    {
        //WL-Changes-start
        reason = null;
        return true;

        //if (session == null)
        //{
        //    reason = FormattedMessage.Empty;
        //    return true;
        //}

        //var manager = collection.Resolve<ISharedPlaytimeManager>();
        //var playtimes = manager.GetPlayTimes(session);
        //return Requirement.Check(collection.Resolve<IEntityManager>(),
        //    collection.Resolve<IPrototypeManager>(),
        //    profile,
        //    /*WL-Changes-start*/null,/*WL-Changes-end*/
        //    playtimes,
        //    out reason);
        //WL-Changes-end
    }
}
