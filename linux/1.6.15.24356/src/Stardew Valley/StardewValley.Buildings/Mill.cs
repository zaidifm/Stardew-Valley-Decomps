using System;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using StardewValley.Inventories;
using StardewValley.Objects;

namespace StardewValley.Buildings;

[Obsolete("The Mill class is only used to preserve data from old save files. All mills were converted into plain Building instances based on the rules in Data/Buildings. The input and output items are now stored in Building.buildingChests with the 'Input' and 'Output' keys respectively.")]
public class Mill : Building
{
	[XmlElement("input")]
	public Chest obsolete_input;

	[XmlElement("output")]
	public Chest obsolete_output;

	public Mill(Vector2 tileLocation)
		: base("Mill", tileLocation)
	{
	}

	public Mill()
		: this(Vector2.Zero)
	{
	}

	public void TransferValuesToNewBuilding(Building targetBuilding)
	{
		Chest chest = obsolete_input;
		if (chest != null && chest.Items?.Count > 0)
		{
			IInventory items = obsolete_input.Items;
			Chest buildingChest = targetBuilding.GetBuildingChest("Input");
			for (int i = 0; i < items.Count; i++)
			{
				Item item = items[i];
				if (item != null)
				{
					items[i] = null;
					buildingChest.addItem(item);
				}
			}
			obsolete_input = null;
		}
		Chest chest2 = obsolete_output;
		if (chest2 == null || !(chest2.Items?.Count > 0))
		{
			return;
		}
		IInventory items2 = obsolete_output.Items;
		Chest buildingChest2 = targetBuilding.GetBuildingChest("Output");
		for (int j = 0; j < items2.Count; j++)
		{
			Item item2 = items2[j];
			if (item2 != null)
			{
				items2[j] = null;
				buildingChest2.addItem(item2);
			}
		}
		obsolete_output = null;
	}
}
