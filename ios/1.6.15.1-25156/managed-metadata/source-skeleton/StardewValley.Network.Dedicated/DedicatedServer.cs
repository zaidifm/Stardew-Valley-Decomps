using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Network.Dedicated;

public class DedicatedServer
{
	public class FarmerWarp
	{
		public Farmer who;

		public string name;

		public int facingDirection;

		public short x;

		public short y;

		public bool isStructure;

		public bool warpingForForcedRemoteEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FarmerWarp(Farmer who, short x, short y, string name, bool isStructure, int facingDirection, bool warpingForForcedRemoteEvent)
		{
		}
	}

	private const string BROADCAST_EVENT_KEY = "BroadcastEvent";

	private readonly ConcurrentQueue<FarmerWarp> farmerWarps;

	private readonly Dictionary<string, Dictionary<string, long>> eventLocks;

	private readonly HashSet<long> onlineIds;

	private readonly HashSet<string> broadcastEvents;

	private readonly HashSet<string> notBroadcastEvents;

	private bool fakeWarp;

	private bool warpingSleep;

	private bool warpingFestival;

	private bool warpingHostBroadcastEvent;

	private bool startedFestivalMainEvent;

	private bool startedFestivalEnd;

	private bool shouldJudgeGrange;

	public bool CheckedHostPrecondition;

	private long fakeFarmerId;

	public bool FakeWarp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Farmer FakeFarmer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DedicatedServer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetForNewDay()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool TryForceClientHostEvent(FarmerWarp warp, GameLocation location, string eventId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckForWarpEvents(FarmerWarp warp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsWarping()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoHostAction(string action, params object[] data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Tick()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void HandleFarmerWarp(FarmerWarp warp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckOthersReady(string readyCheck)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HostSleepInBed()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProcessEventDone(IncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProcessHostAction(IncomingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessMessage(IncomingMessage message)
	{
	}
}
