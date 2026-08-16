using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using StardewValley.Objects;

namespace StardewValley.Buildings;

[Obsolete("The Mill class is only used to preserve data from old save files. All mills were converted into plain Building instances based on the rules in Data/Buildings. The input and output items are now stored in Building.buildingChests with the 'Input' and 'Output' keys respectively.")]
public class Mill : Building
{
	[XmlElement("input")]
	public Chest obsolete_input;

	[XmlElement("output")]
	public Chest obsolete_output;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mill(Vector2 tileLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mill()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TransferValuesToNewBuilding(Building targetBuilding)
	{
	}
}
