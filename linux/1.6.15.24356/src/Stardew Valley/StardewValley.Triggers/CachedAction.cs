using StardewValley.Delegates;

namespace StardewValley.Triggers;

public class CachedAction
{
	public string[] Args { get; }

	public TriggerActionDelegate Handler { get; }

	public string Error { get; }

	public bool IsNullHandler { get; }

	public CachedAction(string[] args, TriggerActionDelegate handler, string error, bool isNullHandler)
	{
		Args = args;
		Handler = handler;
		Error = error;
		IsNullHandler = isNullHandler;
	}
}
