using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Network;

namespace StardewValley.Locations;

public class Racer : INetObject<NetFields>
{
	public NetBool moving;

	public Vector2? lastPosition;

	public NetPosition position;

	public NetInt direction;

	public float horizontalPosition;

	public int currentTrackIndex;

	public Vector2 segmentStart;

	public Vector2 segmentEnd;

	public NetVector2 jumpSegmentStart;

	public NetVector2 jumpSegmentEnd;

	public NetBool jumping;

	public NetBool tripping;

	public NetBool drawAboveMap;

	public float moveSpeed;

	public float minMoveSpeed;

	public float maxMoveSpeed;

	public float height;

	public float tripTimer;

	public NetInt racerIndex;

	protected Texture2D _texture;

	public bool frame;

	public float nextFrameSwap;

	public float burstDuration;

	public float nextBurst;

	public float extraLuck;

	public float gravity;

	public int _tripLeaps;

	public float progress;

	public NetInt sabotages;

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
	public Racer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Racer(int index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetMoveSpeed()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateRaceProgress(DesertFestival location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update(DesertFestival location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SpeedBurst()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Draw(SpriteBatch sb)
	{
	}
}
