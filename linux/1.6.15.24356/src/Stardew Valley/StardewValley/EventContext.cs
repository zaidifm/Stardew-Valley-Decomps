using Microsoft.Xna.Framework;

namespace StardewValley;

public class EventContext
{
	public Event Event { get; }

	public GameLocation Location { get; }

	public GameTime Time { get; }

	public string[] Args { get; }

	public EventContext(Event @event, GameLocation location, GameTime time, string[] args)
	{
		Event = @event;
		Location = location;
		Time = time;
		Args = args;
	}

	public void LogError(string error, bool willSkip = false)
	{
		Event.LogCommandError(Args, error, willSkip);
	}

	public void LogErrorAndSkip(string error, bool hideError = false)
	{
		Event.LogCommandErrorAndSkip(Args, error, hideError);
	}
}
