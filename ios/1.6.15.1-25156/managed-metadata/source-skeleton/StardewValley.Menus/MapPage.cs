using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.WorldMaps;

namespace StardewValley.Menus;

public class MapPage : IClickableMenu
{
	[Flags]
	public enum WorldMapDebugLineType
	{
		None = 0,
		Areas = 1,
		Positions = 2,
		Tooltips = 4,
		All = -1
	}

	public static WorldMapDebugLineType EnableDebugLines;

	public readonly MapAreaPositionWithContext? mapPosition;

	public readonly MapRegion mapRegion;

	public readonly MapArea[] mapAreas;

	public readonly string scrollText;

	public readonly int defaultComponentID;

	public Rectangle mapBounds;

	public readonly Dictionary<string, ClickableComponent> points;

	public string hoverText;

	private float mapScale;

	private ClickableComponent mapHit;

	private int infoTextHeight;

	private int infoHeight;

	private int infoWidth;

	private int infoX;

	private string infoHeaderString;

	private string infoBodyString;

	private Vector2 mapOffset;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MapPage(int x, int y, int width, int height)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void populateClickableComponentList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNeighborId(ClickableComponent component, string direction, string neighborKeys)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetNeighborId(string keys, out int id, out bool foundIgnore, bool isAlias = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doSelection(int x, int y, bool playSound)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Matrix GetMapTransform()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawMiniPortraits(SpriteBatch b, float alpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawScroll(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawMap(SpriteBatch b, bool drawBorders = true, float alpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawTooltip(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point GetNormalizedPlayerTile(Farmer player)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
