using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley.Minigames;

public class NetLeaderboardsEntry : INetObject<NetFields>
{
	public readonly NetString name;

	public readonly NetInt score;

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
	public void InitNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetLeaderboardsEntry()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetLeaderboardsEntry(string new_name, int new_score)
	{
	}
}
