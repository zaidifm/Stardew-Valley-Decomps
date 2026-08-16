using System.Collections.Generic;
using StardewValley.GameData;

namespace StardewValley.Delegates;

public readonly struct TriggerActionContext(string trigger, object[] triggerArgs, TriggerActionData data, Dictionary<string, object> customFields = null)
{
	public readonly string Trigger = trigger;

	public readonly object[] TriggerArgs = triggerArgs;

	public readonly TriggerActionData Data = data;

	public readonly Dictionary<string, object> CustomFields = customFields;
}
