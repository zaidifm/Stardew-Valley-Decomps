using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Network;

namespace StardewValley;

public class MapSeat : INetObject<NetFields>, ISittable
{
	[XmlIgnore]
	public static Texture2D mapChairTexture;

	[XmlIgnore]
	public NetLongDictionary<int, NetInt> sittingFarmers;

	[XmlIgnore]
	public NetVector2 tilePosition;

	[XmlIgnore]
	public NetVector2 size;

	[XmlIgnore]
	public NetInt direction;

	[XmlIgnore]
	public NetVector2 drawTilePosition;

	[XmlIgnore]
	public NetBool seasonal;

	[XmlIgnore]
	public NetString seatType;

	[XmlIgnore]
	public NetString textureFile;

	[XmlIgnore]
	public string _loadedTextureFile;

	[XmlIgnore]
	public Texture2D overlayTexture;

	[XmlIgnore]
	public int localSittingDirection;

	[XmlIgnore]
	public Vector3? customDrawValues;

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
	public MapSeat()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MapSeat FromData(string data, int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBlocked(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSittingHere(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasSittingFarmers()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Vector2> GetSeatPositions(bool ignore_offsets = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool OccupiesTile(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Vector2? AddSittingFarmer(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSeatHere(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetSittingDirection()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2? GetSittingPosition(Farmer who, bool ignore_offsets = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Rectangle GetSeatBounds()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RemoveSittingFarmer(Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetSittingFarmerCount()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckSeatOccupancyIfTemporaryMap(Farmer who, List<Vector2> seatPositions, out bool[] seatsFilled)
	{
	}
}
