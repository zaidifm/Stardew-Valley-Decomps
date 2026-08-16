using System.IO;
using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley.Monsters;

internal class ParryEventArgs : NetEventArg
{
	public int damage;

	private long farmerId;

	public Farmer who
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ParryEventArgs()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ParryEventArgs(int damage, Farmer who)
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
}
