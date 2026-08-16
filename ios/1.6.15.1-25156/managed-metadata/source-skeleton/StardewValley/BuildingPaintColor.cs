using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley;

public class BuildingPaintColor : INetObject<NetFields>
{
	public NetString ColorName;

	public NetBool Color1Default;

	public NetInt Color1Hue;

	public NetInt Color1Saturation;

	public NetInt Color1Lightness;

	public NetBool Color2Default;

	public NetInt Color2Hue;

	public NetInt Color2Saturation;

	public NetInt Color2Lightness;

	public NetBool Color3Default;

	public NetInt Color3Hue;

	public NetInt Color3Saturation;

	public NetInt Color3Lightness;

	protected bool _dirty;

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
	public BuildingPaintColor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CopyFrom(BuildingPaintColor other)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDefaultFlagChanged(NetBool field, bool old_value, bool new_value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnColorChanged(NetInt field, int old_value, int new_value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Poll(Action apply)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsDirty()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool RequiresRecolor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
