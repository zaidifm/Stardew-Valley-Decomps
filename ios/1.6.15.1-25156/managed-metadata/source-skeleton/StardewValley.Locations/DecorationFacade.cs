using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Netcode;
using StardewValley.Network;

namespace StardewValley.Locations;

public class DecorationFacade : SerializationCollectionFacade<int>
{
	public delegate void ChangeEvent(int whichRoom, int which);

	public readonly NetIntDictionary<int, NetInt> Field;

	[CompilerGenerated]
	private ChangeEvent m_OnChange;

	private List<Action> pendingChanges;

	[NonInstancedStatic]
	public static bool warnedDeprecated;

	public int this[int whichRoom]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public event ChangeEvent OnChange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DecorationFacade()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void changed(int whichRoom, int which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override List<int> Serialize()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void DeserializeAdd(int serialValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(DecorationFacade other)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCountAtLeast(int targetCount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void WarnDeprecation()
	{
	}
}
