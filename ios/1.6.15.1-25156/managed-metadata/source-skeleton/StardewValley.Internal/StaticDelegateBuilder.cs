using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Internal;

public static class StaticDelegateBuilder
{
	private struct CachedDelegate
	{
		public readonly object CreatedDelegate;

		public readonly string Error;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CachedDelegate(object createdDelegate, string error)
		{
		}
	}

	private static readonly Dictionary<Type, Dictionary<string, CachedDelegate>> CachedDelegates;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryCreateDelegate<TDelegate>(string fullMethodName, out TDelegate createdDelegate, out string error) where TDelegate : Delegate
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
