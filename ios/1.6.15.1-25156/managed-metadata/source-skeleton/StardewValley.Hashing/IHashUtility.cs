using System.Runtime.CompilerServices;

namespace StardewValley.Hashing;

public interface IHashUtility
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	int GetDeterministicHashCode(string value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	int GetDeterministicHashCode(params int[] values);
}
