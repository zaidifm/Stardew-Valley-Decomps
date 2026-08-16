using System;
using System.Collections.Generic;

namespace StardewValley.Extensions;

public static class RandomExtensions
{
	public static T Choose<T>(this Random random, T optionA, T optionB)
	{
		if (!(random.NextDouble() < 0.5))
		{
			return optionB;
		}
		return optionA;
	}

	public static T Choose<T>(this Random random, T optionA, T optionB, T optionC)
	{
		return random.Next(3) switch
		{
			0 => optionA, 
			1 => optionB, 
			_ => optionC, 
		};
	}

	public static T Choose<T>(this Random random, T optionA, T optionB, T optionC, T optionD)
	{
		return random.Next(4) switch
		{
			0 => optionA, 
			1 => optionB, 
			2 => optionC, 
			_ => optionD, 
		};
	}

	public static T Choose<T>(this Random random, params T[] options)
	{
		if (options == null || options.Length == 0)
		{
			return default(T);
		}
		return options[random.Next(options.Length)];
	}

	public static T ChooseFrom<T>(this Random random, IList<T> options)
	{
		if (options == null || options.Count <= 0)
		{
			return default(T);
		}
		return options[random.Next(options.Count)];
	}

	public static bool NextBool(this Random random)
	{
		return random.NextDouble() < 0.5;
	}

	public static bool NextBool(this Random random, double chance)
	{
		if (!(chance >= 1.0))
		{
			return random.NextDouble() < chance;
		}
		return true;
	}

	public static bool NextBool(this Random random, float chance)
	{
		if (!(chance >= 1f))
		{
			return random.NextDouble() < (double)chance;
		}
		return true;
	}
}
