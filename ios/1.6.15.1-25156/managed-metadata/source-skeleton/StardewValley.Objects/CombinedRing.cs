using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Buffs;
using StardewValley.Monsters;

namespace StardewValley.Objects;

public class CombinedRing : Ring
{
	public NetList<Ring, NetRef<Ring>> combinedRings;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CombinedRing()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool loadDisplayFields()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool GetsEffectOfRing(string ringId)
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
	public override int GetEffectsOfRingMultiplier(string ringId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void onEquip(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void onUnequip(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AddEquipmentEffects(BuffEffects effects)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void onLeaveLocation(Farmer who, GameLocation environment)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void onMonsterSlay(Monster m, GameLocation location, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void onNewLocation(Farmer who, GameLocation environment)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time, GameLocation environment, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnCombinedRingsChanged()
	{
	}
}
