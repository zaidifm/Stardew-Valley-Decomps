using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley;

public class NPCController
{
	public delegate void endBehavior();

	public Character puppet;

	private bool loop;

	private bool destroyAtNextTurn;

	private List<Vector2> path;

	private Vector2 target;

	private int pathIndex;

	private int pauseTime;

	private int speed;

	private endBehavior behaviorAtEnd;

	private int CurrentPathX
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private int CurrentPathY
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private bool MovingHorizontally
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NPCController(Character n, List<Vector2> path, bool loop, endBehavior endBehavior = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void destroyAtNextCrossroad()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool setMoving(bool newTarget)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool update(GameTime time, GameLocation location, List<NPCController> allControllers)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
