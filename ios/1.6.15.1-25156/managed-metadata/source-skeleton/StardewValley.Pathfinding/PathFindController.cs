using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.Pathfinding;

[InstanceStatics]
public class PathFindController
{
	public delegate bool isAtEnd(PathNode currentNode, Point endPoint, GameLocation location, Character c);

	public delegate void endBehavior(Character c, GameLocation location);

	public const byte impassable = byte.MaxValue;

	public const int timeToWaitBeforeCancelling = 5000;

	private Character character;

	public GameLocation location;

	public Stack<Point> pathToEndPoint;

	public Point endPoint;

	public int finalFacingDirection;

	public int pausedTimer;

	public endBehavior endBehaviorFunction;

	public bool nonDestructivePathing;

	public bool allowPlayerPathingInEvent;

	public bool NPCSchedule;

	protected static readonly sbyte[,] Directions;

	internal static PriorityQueue _openList;

	internal static HashSet<int> _closedList;

	internal static int _counter;

	public int timerSinceLastCheckPoint;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PathFindController(Character c, GameLocation location, Point endPoint, int finalFacingDirection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PathFindController(Character c, GameLocation location, Point endPoint, int finalFacingDirection, endBehavior endBehaviorFunction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PathFindController(Character c, GameLocation location, Point endPoint, int finalFacingDirection, endBehavior endBehaviorFunction, int limit)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PathFindController(Character c, GameLocation location, Point endPoint, int finalFacingDirection, bool clearMarriageDialogues = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isAtEndPoint(PathNode currentNode, Point endPoint, GameLocation location, Character c)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PathFindController(Stack<Point> pathToEndPoint, GameLocation location, Character c, Point endPoint)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PathFindController(Stack<Point> pathToEndPoint, Character c, GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PathFindController(Character c, GameLocation location, isAtEnd endFunction, int finalFacingDirection, endBehavior endBehaviorFunction, int limit, Point endPoint, bool clearMarriageDialogues = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isPlayerPresent()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool update(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Stack<Point> findPath(Point startPoint, Point endPoint, isAtEnd endPointFunction, GameLocation location, Character character, int limit)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Stack<Point> reconstructPath(PathNode finalNode)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void moveCharacter(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void handleWarps(Rectangle position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete("Use findPathForNPCSchedules overload with 'npc' parameter.")]
	public static Stack<Point> findPathForNPCSchedules(Point startPoint, Point endPoint, GameLocation location, int limit)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Stack<Point> findPathForNPCSchedules(Point startPoint, Point endPoint, GameLocation location, int limit, Character npc)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static bool isPositionImpassableForNPCSchedule(GameLocation loc, int x, int y, Character npc)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static int getPreferenceValueForTerrainType(GameLocation l, int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
