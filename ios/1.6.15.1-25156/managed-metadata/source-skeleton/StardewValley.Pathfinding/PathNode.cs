using System;
using System.Runtime.CompilerServices;

namespace StardewValley.Pathfinding;

public class PathNode : IEquatable<PathNode>
{
	public readonly int x;

	public readonly int y;

	public readonly int id;

	public byte g;

	public PathNode parent;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PathNode(int x, int y, PathNode parent)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PathNode(int x, int y, byte g, PathNode parent)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(PathNode obj)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ComputeHash(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
