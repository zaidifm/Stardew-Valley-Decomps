using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StardewValley.GameData;

namespace StardewValley.Delegates;

public readonly struct TriggerActionContext
{
	public readonly string Trigger;

	public readonly object[] TriggerArgs;

	public readonly TriggerActionData Data;

	public readonly Dictionary<string, object> CustomFields;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TriggerActionContext(string trigger, object[] triggerArgs, TriggerActionData data, Dictionary<string, object> customFields = null)
	{
	}
}
