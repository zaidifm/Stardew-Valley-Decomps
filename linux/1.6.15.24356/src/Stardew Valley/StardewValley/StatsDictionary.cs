using System;
using StardewValley.Extensions;

namespace StardewValley;

public class StatsDictionary<TValue> : SerializableDictionaryWithCaseInsensitiveKeys<TValue>
{
	protected override void AddDuringDeserialization(string key, TValue value)
	{
		if (!TryGetValue(key, out var value2))
		{
			base.AddDuringDeserialization(key, value);
			return;
		}
		long num = Convert.ToInt64(value);
		long num2 = Convert.ToInt64(value2);
		if (key.EqualsIgnoreCase("averageBedtime"))
		{
			if (num2 == 0L)
			{
				base[key] = value;
			}
		}
		else
		{
			base[key] = (TValue)Convert.ChangeType(num2 + num, typeof(TValue));
		}
	}
}
