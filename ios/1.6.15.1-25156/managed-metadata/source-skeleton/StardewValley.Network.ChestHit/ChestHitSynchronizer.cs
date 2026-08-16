using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Network.ChestHit;

public sealed class ChestHitSynchronizer
{
	private readonly Queue<ChestHitArgs> EventQueue;

	internal readonly Dictionary<string, Dictionary<ulong, ChestHitTimer>> SavedTimers;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Sync(ChestHitArgs args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SignalMove(GameLocation location, int sourceTileX, int sourceTileY, int destTileX, int destTileY)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SignalDelete(GameLocation location, int tileX, int tileY)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessMessage(IncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ulong HashPosition(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GameLocation ReadLocation(IncomingMessage message)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProcessSync(IncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProcessMove(IncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProcessDelete(IncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChestHitSynchronizer()
	{
	}
}
