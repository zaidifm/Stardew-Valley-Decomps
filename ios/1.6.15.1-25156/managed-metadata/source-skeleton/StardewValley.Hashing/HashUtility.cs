using System.Data.HashFunction;
using System.Runtime.CompilerServices;

namespace StardewValley.Hashing;

public class HashUtility : IHashUtility
{
	private static readonly IHashFunction Hasher;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDeterministicHashCode(string value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDeterministicHashCode(params int[] values)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDeterministicHashCode(byte[] data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HashUtility()
	{
	}
}
