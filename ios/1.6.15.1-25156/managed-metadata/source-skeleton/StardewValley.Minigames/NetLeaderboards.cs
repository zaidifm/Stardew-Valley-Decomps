using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley.Minigames;

public class NetLeaderboards : INetObject<NetFields>
{
	public NetObjectList<NetLeaderboardsEntry> entries;

	public NetInt maxEntries;

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
	public NetLeaderboards()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddScore(string name, int score)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<KeyValuePair<string, int>> GetScores()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadScores(List<KeyValuePair<string, int>> scores)
	{
	}
}
