using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Objects;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class IslandFarmHouse : DecoratableLocation
{
	[XmlElement("fridge")]
	public readonly NetRef<Chest> fridge;

	public Point fridgePosition;

	public NetBool visited;

	private Color nightLightingColor;

	private Color rainLightingColor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandFarmHouse()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandFarmHouse(string map, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void TransferDataFromSavedLocation(GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<Microsoft.Xna.Framework.Rectangle> getWalls()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point? GetFridgePositionFromMap()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<Microsoft.Xna.Framework.Rectangle> getFloors()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitializeBeds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void _updateAmbientLighting()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
