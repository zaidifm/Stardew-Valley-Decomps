using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;

namespace StardewValley.Pathfinding;

public class SchedulePathDescription
{
	[XmlIgnore]
	public Stack<Point> route;

	public int time;

	public int facingDirection;

	public string endOfRouteBehavior;

	public string endOfRouteMessage;

	public string targetLocationName;

	public Point targetTile;

	[XmlIgnore]
	public Stack<string> locationNames;

	public List<Point> _route;

	public List<string> _locationNames;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SchedulePathDescription()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SchedulePathDescription(Stack<Point> route, int facingDirection, string endBehavior, string endMessage, string targetLocationName, Point targetTile, Stack<string> locationNames = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void emergencySave()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void emergencyLoad()
	{
	}
}
