using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley.Buildings;
using StardewValley.Delegates;
using StardewValley.Inventories;
using StardewValley.Network;

namespace StardewValley.Internal;

public readonly struct ForEachItemContext(Item item, Action remove, Action<Item> replaceWith, GetForEachItemPathDelegate getPath)
{
	public readonly Item Item = item;

	public readonly Action RemoveItem = remove;

	public readonly Action<Item> ReplaceItemWith = replaceWith;

	public readonly GetForEachItemPathDelegate GetPath = getPath;

	public IList<string> GetDisplayPath(bool includeItem = false)
	{
		List<string> list = new List<string>();
		foreach (object item in GetPath())
		{
			AddDisplayPath(list, item);
		}
		if (includeItem)
		{
			AddDisplayPath(list, Item);
		}
		return list;
	}

	private void AddDisplayPath(IList<string> path, object pathValue)
	{
		if (!(pathValue is GameLocation gameLocation))
		{
			if (!(pathValue is Building building))
			{
				if (!(pathValue is Object obj))
				{
					if (!(pathValue is Farmer farmer))
					{
						if (!(pathValue is Item item))
						{
							if (!(pathValue is INetSerializable netSerializable))
							{
								if (!(pathValue is IInventory) && !(pathValue is OverlaidDictionary))
								{
									path.Add(pathValue.ToString());
								}
							}
							else
							{
								path.Add(netSerializable.Name);
							}
						}
						else
						{
							path.Add(item.Name);
						}
					}
					else
					{
						path.Add("player '" + farmer.Name + "'");
					}
				}
				else
				{
					if (path.Count == 0 && obj.Location != null)
					{
						AddDisplayPath(path, obj.Location);
					}
					path.Add((obj.TileLocation != Vector2.Zero) ? $"{obj.Name} at {obj.TileLocation.X}, {obj.TileLocation.Y}" : obj.Name);
				}
				return;
			}
			if (path.Count == 0)
			{
				GameLocation parentLocation = building.GetParentLocation();
				if (parentLocation != null)
				{
					AddDisplayPath(path, parentLocation);
				}
			}
			path.Add($"{building.buildingType.Value} at {building.tileX.Value}, {building.tileY.Value}");
		}
		else
		{
			if (path.Count == 0 && gameLocation.ParentBuilding != null)
			{
				AddDisplayPath(path, gameLocation.ParentBuilding);
			}
			path.Add(gameLocation.NameOrUniqueName);
		}
	}
}
