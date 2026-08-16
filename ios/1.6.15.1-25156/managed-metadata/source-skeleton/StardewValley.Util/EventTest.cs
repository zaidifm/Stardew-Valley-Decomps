using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Util;

public class EventTest
{
	private int currentEventIndex;

	private int currentLocationIndex;

	private int aButtonTimer;

	private List<string> specificEventsToDo;

	private bool doingSpecifics;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EventTest(string startingLocationName = "", int startingEventIndex = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EventTest(string[] whichEvents)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void update()
	{
	}
}
