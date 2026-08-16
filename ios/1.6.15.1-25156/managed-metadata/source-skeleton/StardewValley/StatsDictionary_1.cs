using System.Runtime.CompilerServices;

namespace StardewValley;

public class StatsDictionary<TValue> : SerializableDictionaryWithCaseInsensitiveKeys<TValue>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void AddDuringDeserialization(string key, TValue value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StatsDictionary()
	{
	}
}
