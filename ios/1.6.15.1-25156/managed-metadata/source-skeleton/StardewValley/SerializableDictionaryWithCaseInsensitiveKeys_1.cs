using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley;

public class SerializableDictionaryWithCaseInsensitiveKeys<TValue> : SerializableDictionary<string, TValue>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SerializableDictionaryWithCaseInsensitiveKeys()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SerializableDictionaryWithCaseInsensitiveKeys(IDictionary<string, TValue> data)
	{
	}
}
