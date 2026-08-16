using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.BellsAndWhistles;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class IslandEast : IslandForestLocation
{
	protected PerchingBirds _parrots;

	protected Texture2D _parrotTextures;

	protected NetEvent0 bananaShrineEvent;

	public NetBool bananaShrineComplete;

	public NetBool bananaShrineNutAwarded;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandEast()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandEast(string map, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddTorchLights()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void cleanupBeforePlayerExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SpawnBananaNutReward()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddGorillaShrineTorches(int delay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void TransferDataFromSavedLocation(GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnBananaShrine()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performAction(string[] action, Farmer who, Location tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gorillaReachedShrine(int extra)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gorillaReachedShrineCosmetic(int extra)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gorillaGrabBanana(int extra)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gorillaEatBanana(int extra)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gorillaAfterEat(int extra)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gorillaSpawnNut(int extra)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gorillaReturn(int extra)
	{
	}
}
