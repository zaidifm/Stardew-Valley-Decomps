using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Netcode;
using StardewValley.Network;

namespace StardewValley.Extensions;

public static class GameExtensions
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Add(this IDictionary<string, LightSource> dictionary, LightSource lightSource)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddLight(this NetStringDictionary<LightSource, NetRef<LightSource>> dictionary, LightSource lightSource)
	{
	}
}
