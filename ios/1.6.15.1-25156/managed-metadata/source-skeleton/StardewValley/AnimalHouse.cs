using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley.Buildings;
using xTile.Dimensions;

namespace StardewValley;

public class AnimalHouse : GameLocation
{
	[XmlElement("animalLimit")]
	public readonly NetInt animalLimit;

	public readonly NetLongList animalsThatLiveHere;

	[XmlIgnore]
	public bool hasShownIncubatorBuildingFullMessage;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AnimalHouse()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AnimalHouse(string mapPath, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnParentBuildingUpgraded(Building building)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isFull()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetSharedState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addNewHatchedAnimal(string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void adoptAnimal(FarmAnimal animal)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetPositionsOfAllAnimals()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool dropObject(Object obj, Vector2 location, xTile.Dimensions.Rectangle viewport, bool initialPlacement, Farmer who = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void TransferDataFromSavedLocation(GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void feedAllAnimals()
	{
	}
}
