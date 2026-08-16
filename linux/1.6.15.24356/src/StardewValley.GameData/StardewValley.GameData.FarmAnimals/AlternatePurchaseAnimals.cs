using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.FarmAnimals;

public class AlternatePurchaseAnimals
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public string Condition;

	public List<string> AnimalIds;
}
