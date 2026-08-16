using System.Runtime.CompilerServices;
using Netcode;
using StardewValley.Network;

namespace StardewValley.Mods;

public class ModDataDictionary : NetStringDictionary<string, NetString>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ModDataDictionary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetFromSerialization(ModDataDictionary source)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ModDataDictionary GetForSerialization()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopyFrom(ModDataDictionary dict)
	{
	}
}
