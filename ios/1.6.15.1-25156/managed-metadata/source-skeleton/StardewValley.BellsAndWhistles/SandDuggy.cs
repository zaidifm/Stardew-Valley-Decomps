using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Network;

namespace StardewValley.BellsAndWhistles;

public class SandDuggy : INetObject<NetFields>
{
	[XmlType("SandDuggy.State")]
	public enum State
	{
		DigUp,
		Idle,
		DigDown
	}

	[XmlIgnore]
	public NetList<Point, NetPoint> holeLocations;

	[XmlIgnore]
	public int frame;

	[XmlIgnore]
	public NetInt currentHoleIndex;

	[XmlIgnore]
	public int _localIndex;

	[XmlIgnore]
	public NetLocationRef locationRef;

	[XmlIgnore]
	public State currentState;

	[XmlIgnore]
	public Texture2D texture;

	[XmlIgnore]
	public float nextFrameUpdate;

	[XmlElement("whacked")]
	public NetBool whacked;

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
	public SandDuggy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SandDuggy(GameLocation location, Point[] points)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int FindRandomFreePoint()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnWhackedChanged(NetBool field, bool old_value, bool new_value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AnimateWhacked()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetForPlayerEntry()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PerformToolAction(Tool tool, int tile_x, int tile_y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool NearFarmer(Point location, Farmer farmer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Draw(SpriteBatch b)
	{
	}
}
