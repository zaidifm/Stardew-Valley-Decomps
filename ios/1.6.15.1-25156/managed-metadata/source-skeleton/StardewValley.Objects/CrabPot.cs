using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Inventories;

namespace StardewValley.Objects;

public class CrabPot : Object
{
	public const int lidFlapTimerInterval = 60;

	[XmlIgnore]
	public float yBob;

	[XmlElement("directionOffset")]
	public readonly NetVector2 directionOffset;

	[XmlElement("bait")]
	public readonly NetRef<Object> bait;

	public int tileIndexToShow;

	[XmlIgnore]
	public bool lidFlapping;

	[XmlIgnore]
	public bool lidClosing;

	[XmlIgnore]
	public float lidFlapTimer;

	[XmlIgnore]
	public new float shakeTimer;

	[XmlIgnore]
	public Vector2 shake;

	[XmlIgnore]
	private int ignoreRemovalTimer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CrabPot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool NeedsBait(Farmer player)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Vector2> getOverlayTiles()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void addOverlayTilesIfNecessary(int tile_x, int tile_y, List<Vector2> tiles)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addOverlayTiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void removeOverlayTiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValidCrabPotLocationTile(GameLocation location, int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void actionOnPlayerEntry()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool placementAction(GameLocation location, int x, int y, Farmer who = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateOffset()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool checkLocation(float tile_x, float tile_y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Item GetOneNew()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performObjectDropInAction(Item dropInItem, bool probe, Farmer who, bool returnFalseIfItemConsumed = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool AttemptAutoLoad(IInventory inventory, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performRemoveAction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate()
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
	public static bool CanPlaceHere(GameLocation gameLocation, Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector2 FetchTileOffsetPosition(GameLocation location, Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
