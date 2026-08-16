using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley;

public class EventContext
{
	public Event Event
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public GameLocation Location
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public GameTime Time
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public string[] Args
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EventContext(Event @event, GameLocation location, GameTime time, string[] args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogError(string error, bool willSkip = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogErrorAndSkip(string error, bool hideError = false)
	{
	}
}
