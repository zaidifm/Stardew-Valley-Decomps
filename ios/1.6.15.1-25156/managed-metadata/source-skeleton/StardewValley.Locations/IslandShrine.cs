using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley.Objects;

namespace StardewValley.Locations;

public class IslandShrine : IslandForestLocation
{
	[XmlIgnore]
	public ItemPedestal northPedestal;

	[XmlIgnore]
	public ItemPedestal southPedestal;

	[XmlIgnore]
	public ItemPedestal eastPedestal;

	[XmlIgnore]
	public ItemPedestal westPedestal;

	[XmlIgnore]
	public NetEvent0 puzzleFinishedEvent;

	[XmlElement("puzzleFinished")]
	public NetBool puzzleFinished;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandShrine()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandShrine(string map, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<Vector2> GetAdditionalWalnutBushes()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemPedestal AddOrUpdatePedestal(Vector2 position, string birdLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddMissingPedestals()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void MakeMapModifications(bool force = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void TransferDataFromSavedLocation(GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPuzzleFinish()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ApplyFinishedTiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}
}
