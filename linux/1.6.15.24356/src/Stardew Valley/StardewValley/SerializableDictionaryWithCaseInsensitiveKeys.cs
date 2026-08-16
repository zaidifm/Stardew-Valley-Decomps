using System;
using System.Collections.Generic;

namespace StardewValley;

public class SerializableDictionaryWithCaseInsensitiveKeys<TValue> : SerializableDictionary<string, TValue>
{
	public SerializableDictionaryWithCaseInsensitiveKeys()
		: base((IEqualityComparer<string>)StringComparer.OrdinalIgnoreCase)
	{
	}

	public SerializableDictionaryWithCaseInsensitiveKeys(IDictionary<string, TValue> data)
		: base(data, (IEqualityComparer<string>)StringComparer.OrdinalIgnoreCase)
	{
	}
}
