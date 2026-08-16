using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley.Network;

public class NetCharacterRef : INetObject<NetFields>
{
	private readonly NetNPCRef npc;

	private readonly NetFarmerRef farmer;

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
	public NetCharacterRef()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Character Get(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(GameLocation location, Character character)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
	}
}
