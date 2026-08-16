using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley;

public class Warp : INetObject<NetFields>
{
	[XmlElement("x")]
	private readonly NetInt x;

	[XmlElement("y")]
	private readonly NetInt y;

	[XmlElement("targetX")]
	private readonly NetInt targetX;

	[XmlElement("targetY")]
	private readonly NetInt targetY;

	[XmlElement("flipFarmer")]
	public readonly NetBool flipFarmer;

	[XmlElement("targetName")]
	private readonly NetString targetName;

	[XmlElement("npcOnly")]
	public readonly NetBool npcOnly;

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

	public int X
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int Y
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int TargetX
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

	public int TargetY
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

	public string TargetName
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Warp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Warp(int x, int y, string targetName, int targetX, int targetY, bool flipFarmer, bool npcOnly = false)
	{
	}
}
