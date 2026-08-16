using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley.Network;

public class NetNPCRef : INetObject<NetFields>
{
	private readonly NetGuid guid;

	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetNPCRef()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NPC Get(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(GameLocation location, NPC npc)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
	}
}
