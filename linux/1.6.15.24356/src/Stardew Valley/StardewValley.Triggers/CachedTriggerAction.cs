using StardewValley.GameData;

namespace StardewValley.Triggers;

public class CachedTriggerAction
{
	public TriggerActionData Data { get; }

	public CachedAction[] Actions { get; }

	public string[] ActionStrings { get; }

	public CachedTriggerAction(TriggerActionData data, CachedAction[] actions)
	{
		Data = data;
		Actions = actions;
		if (actions.Length == 0)
		{
			ActionStrings = LegacyShims.EmptyArray<string>();
			return;
		}
		ActionStrings = new string[actions.Length];
		for (int i = 0; i < actions.Length; i++)
		{
			ActionStrings[i] = string.Join(" ", actions[i].Args);
		}
	}
}
