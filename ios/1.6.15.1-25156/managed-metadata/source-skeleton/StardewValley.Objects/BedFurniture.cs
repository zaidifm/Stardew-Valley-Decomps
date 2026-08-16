using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Network;

namespace StardewValley.Objects;

public class BedFurniture : Furniture
{
	public enum BedType
	{
		Any = -1,
		Single,
		Double,
		Child
	}

	public static string DEFAULT_BED_INDEX;

	public static string DOUBLE_BED_INDEX;

	public static string CHILD_BED_INDEX;

	[XmlIgnore]
	public int bedTileOffset;

	[XmlIgnore]
	protected bool _alreadyAttempingRemoval;

	[XmlIgnore]
	public static bool ignoreContextualBedSpotOffset;

	[XmlIgnore]
	protected NetEnum<BedType> _bedType;

	[XmlIgnore]
	public NetMutex mutex;

	[XmlElement("bedType")]
	public BedType bedType
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
	public BedFurniture()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BedFurniture(string itemId, Vector2 tile, int initialRotations)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BedFurniture(string itemId, Vector2 tile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsBeingSleptIn()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ReserveForNPC()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AttemptRemoval(Action<Furniture> removal_action)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BedFurniture GetBedAtTile(GameLocation location, int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ApplyWakeUpPosition(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShiftPositionForBed(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanModifyBed(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetAdditionalFurniturePlacementStatus(GameLocation location, int x, int y, Farmer who = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool placementAction(GameLocation location, int x, int y, Farmer who = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performRemoveAction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void hoverAction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool canBeRemoved(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Item GetOneNew()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void GetOneCopyFrom(Item source)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Point GetBedSpot()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void actionOnPlayerEntryOrPlacement(GameLocation environment, bool dropDown)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateBedTile(bool check_bounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool AllowPlacementOnThisTile(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IntersectsForCollision(Rectangle rect)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetAdditionalTilePropertyRadius()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsBedHere(GameLocation location, int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool DoesTileHaveProperty(int tile_x, int tile_y, string property_name, string layer_name, ref string property_value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
