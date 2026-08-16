using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley.Network;

namespace StardewValley;

public class Chunk : INetObject<NetFields>
{
	public const int MinSinkTimer = 1900;

	public const int MaxSinkTimer = 2400;

	[XmlElement("position")]
	public NetPosition position;

	[XmlIgnore]
	public readonly NetFloat xVelocity;

	[XmlIgnore]
	public readonly NetFloat yVelocity;

	[XmlIgnore]
	public readonly NetBool hasPassedRestingLineOnce;

	[XmlIgnore]
	public int bounces;

	[XmlIgnore]
	public float bob;

	public readonly NetInt sinkTimer;

	public readonly NetInt netDebrisType;

	[XmlIgnore]
	public bool hitWall;

	[XmlElement("xSpriteSheet")]
	public readonly NetInt xSpriteSheet;

	[XmlElement("ySpriteSheet")]
	public readonly NetInt ySpriteSheet;

	[XmlIgnore]
	public float rotation;

	[XmlIgnore]
	public float rotationVelocity;

	private readonly NetFloat netScale;

	private readonly NetFloat netAlpha;

	public int randomOffset
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

	public float scale
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

	public float alpha
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
	public Chunk()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Chunk(Vector2 position, float xVelocity, float yVelocity, int random_offset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float getSpeed()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 GetVisualPosition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
