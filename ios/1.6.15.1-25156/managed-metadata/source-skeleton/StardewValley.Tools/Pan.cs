using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.Tools;

public class Pan : Tool
{
	[XmlIgnore]
	private readonly NetEvent0 finishEvent;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Pan()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Pan(int upgradeLevel)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Item GetOneNew()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool beginUsing(GameLocation location, int x, int y, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void playSlosh(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void tickUpdate(GameTime time, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoFunction(GameLocation location, int x, int y, int power, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void finish()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doFinish()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Item> getPanItems(GameLocation location, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
