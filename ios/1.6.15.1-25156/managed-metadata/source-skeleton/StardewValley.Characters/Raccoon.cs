using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Menus;
using StardewValley.Network;

namespace StardewValley.Characters;

public class Raccoon : NPC
{
	[XmlElement("mrs_raccoon")]
	public readonly NetBool mrs_raccoon;

	[XmlIgnore]
	public readonly NetMutex mutex;

	private bool wasTalkedTo;

	private float updateFacingDirectionTimer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Raccoon()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Raccoon(bool mrs_racooon = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void reloadSprite(bool onlyAppearance = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void activate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void dayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _activateMrRaccoon()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Bundle GetBundle()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Bundle GetBundle(int timesFed)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item getBundleReward()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void bundleCompleteAfterSwipe(JunimoNoteMenu menu)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void bundleComplete(JunimoNoteMenu menu)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void AddNextIngredient(List<BundleIngredientDescription> ingredients, int whichBundle, Random r)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Farmer who, GameLocation l)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performTenMinuteUpdate(int timeOfDay, GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
