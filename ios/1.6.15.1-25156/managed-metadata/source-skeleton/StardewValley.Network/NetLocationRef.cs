using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.Network;

public class NetLocationRef : INetObject<NetFields>
{
	public readonly NetString locationName;

	public readonly NetBool isStructure;

	protected GameLocation _gameLocation;

	protected bool _dirty;

	protected bool _usedLocalLocation;

	[XmlIgnore]
	public Action OnLocationChanged;

	public string LocationName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool IsStructure
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public GameLocation Value
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

	[XmlIgnore]
	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetLocationRef()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetLocationRef(GameLocation value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsChanging()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(bool forceUpdate = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyChangesIfDirty()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameLocation Get()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsCurrentlyViewedLocation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
