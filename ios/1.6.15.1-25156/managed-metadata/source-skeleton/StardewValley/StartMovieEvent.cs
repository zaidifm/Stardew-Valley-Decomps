using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley;

public class StartMovieEvent : NetEventArg
{
	public long uid;

	public List<List<Character>> playerGroups;

	public List<List<Character>> npcGroups;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StartMovieEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StartMovieEvent(long farmer_uid, List<List<Character>> player_groups, List<List<Character>> npc_groups)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(BinaryReader reader)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(BinaryWriter writer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<List<Character>> ReadCharacterList(BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WriteCharacterList(BinaryWriter writer, List<List<Character>> group_list)
	{
	}
}
