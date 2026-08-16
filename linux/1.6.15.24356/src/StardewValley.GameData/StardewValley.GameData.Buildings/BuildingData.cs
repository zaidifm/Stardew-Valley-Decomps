using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Buildings;

public class BuildingData
{
	public string Name;

	[ContentSerializer(Optional = true)]
	public string NameForGeneralType;

	public string Description;

	public string Texture;

	[ContentSerializer(Optional = true)]
	public List<BuildingSkin> Skins = new List<BuildingSkin>();

	[ContentSerializer(Optional = true)]
	public bool DrawShadow = true;

	[ContentSerializer(Optional = true)]
	public Vector2 UpgradeSignTile = new Vector2(-1f, -1f);

	[ContentSerializer(Optional = true)]
	public float UpgradeSignHeight;

	[ContentSerializer(Optional = true)]
	public Point Size = new Point(1, 1);

	[ContentSerializer(Optional = true)]
	public bool FadeWhenBehind = true;

	[ContentSerializer(Optional = true)]
	public Rectangle SourceRect = Rectangle.Empty;

	[ContentSerializer(Optional = true)]
	public Point SeasonOffset = Point.Zero;

	[ContentSerializer(Optional = true)]
	public Vector2 DrawOffset = Vector2.Zero;

	[ContentSerializer(Optional = true)]
	public float SortTileOffset;

	[ContentSerializer(Optional = true)]
	public string CollisionMap;

	[ContentSerializer(Optional = true)]
	public List<BuildingPlacementTile> AdditionalPlacementTiles;

	[ContentSerializer(Optional = true)]
	public string BuildingType;

	[ContentSerializer(Optional = true)]
	public string Builder = "Robin";

	[ContentSerializer(Optional = true)]
	public string BuildCondition;

	[ContentSerializer(Optional = true)]
	public int BuildDays;

	[ContentSerializer(Optional = true)]
	public int BuildCost;

	[ContentSerializer(Optional = true)]
	public List<BuildingMaterial> BuildMaterials;

	[ContentSerializer(Optional = true)]
	public string BuildingToUpgrade;

	[ContentSerializer(Optional = true)]
	public bool MagicalConstruction;

	[ContentSerializer(Optional = true)]
	public Point BuildMenuDrawOffset = Point.Zero;

	[ContentSerializer(Optional = true)]
	public Point HumanDoor = new Point(-1, -1);

	[ContentSerializer(Optional = true)]
	public Rectangle AnimalDoor = new Rectangle(-1, -1, 0, 0);

	[ContentSerializer(Optional = true)]
	public float AnimalDoorOpenDuration;

	[ContentSerializer(Optional = true)]
	public string AnimalDoorOpenSound;

	[ContentSerializer(Optional = true)]
	public float AnimalDoorCloseDuration;

	[ContentSerializer(Optional = true)]
	public string AnimalDoorCloseSound;

	[ContentSerializer(Optional = true)]
	public string NonInstancedIndoorLocation;

	[ContentSerializer(Optional = true)]
	public string IndoorMap;

	[ContentSerializer(Optional = true)]
	public string IndoorMapType;

	[ContentSerializer(Optional = true)]
	public int MaxOccupants = 20;

	[ContentSerializer(Optional = true)]
	public List<string> ValidOccupantTypes = new List<string>();

	[ContentSerializer(Optional = true)]
	public bool AllowAnimalPregnancy;

	[ContentSerializer(Optional = true)]
	public List<IndoorItemMove> IndoorItemMoves;

	[ContentSerializer(Optional = true)]
	public List<IndoorItemAdd> IndoorItems;

	[ContentSerializer(Optional = true)]
	public List<string> AddMailOnBuild;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> Metadata = new Dictionary<string, string>();

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> ModData = new Dictionary<string, string>();

	[ContentSerializer(Optional = true)]
	public int HayCapacity;

	[ContentSerializer(Optional = true)]
	public List<BuildingChest> Chests;

	[ContentSerializer(Optional = true)]
	public string DefaultAction;

	[ContentSerializer(Optional = true)]
	public int AdditionalTilePropertyRadius;

	[ContentSerializer(Optional = true)]
	public bool AllowsFlooringUnderneath = true;

	[ContentSerializer(Optional = true)]
	public List<BuildingActionTile> ActionTiles = new List<BuildingActionTile>();

	[ContentSerializer(Optional = true)]
	public List<BuildingTileProperty> TileProperties = new List<BuildingTileProperty>();

	[ContentSerializer(Optional = true)]
	public List<BuildingItemConversion> ItemConversions;

	[ContentSerializer(Optional = true)]
	public List<BuildingDrawLayer> DrawLayers;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;

	protected Dictionary<Point, string> _actionTiles;

	protected Dictionary<Point, bool> _collisionMap;

	protected Dictionary<string, Dictionary<Point, Dictionary<string, string>>> _tileProperties;

	public bool IsTilePassable(int relativeX, int relativeY)
	{
		if (CollisionMap == null)
		{
			if (relativeX >= 0 && relativeX < Size.X && relativeY >= 0 && relativeY < Size.Y)
			{
				return false;
			}
			return true;
		}
		Point key = new Point(relativeX, relativeY);
		if (_collisionMap == null)
		{
			_collisionMap = new Dictionary<Point, bool>();
			if (CollisionMap != null)
			{
				string[] array = CollisionMap.Trim().Split('\n');
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i].Trim();
					for (int j = 0; j < text.Length; j++)
					{
						_collisionMap[new Point(j, i)] = text[j] == 'X';
					}
				}
			}
		}
		if (_collisionMap.TryGetValue(key, out var value))
		{
			return !value;
		}
		return true;
	}

	public string GetActionAtTile(int relativeX, int relativeY)
	{
		Point key = new Point(relativeX, relativeY);
		if (_actionTiles == null)
		{
			_actionTiles = new Dictionary<Point, string>();
			foreach (BuildingActionTile actionTile in ActionTiles)
			{
				_actionTiles[actionTile.Tile] = actionTile.Action;
			}
		}
		if (!_actionTiles.TryGetValue(key, out var value))
		{
			if (relativeX < 0 || relativeX >= Size.X || relativeY < 0 || relativeY >= Size.Y)
			{
				return null;
			}
			return DefaultAction;
		}
		return value;
	}

	public bool HasPropertyAtTile(int relativeX, int relativeY, string propertyName, string layerName, ref string propertyValue)
	{
		if (_tileProperties == null)
		{
			_tileProperties = new Dictionary<string, Dictionary<Point, Dictionary<string, string>>>();
			foreach (BuildingTileProperty tileProperty in TileProperties)
			{
				if (!_tileProperties.TryGetValue(tileProperty.Layer, out var value))
				{
					value = (_tileProperties[tileProperty.Layer] = new Dictionary<Point, Dictionary<string, string>>());
				}
				for (int i = tileProperty.TileArea.Y; i < tileProperty.TileArea.Bottom; i++)
				{
					for (int j = tileProperty.TileArea.X; j < tileProperty.TileArea.Right; j++)
					{
						Point key = new Point(j, i);
						if (!value.TryGetValue(key, out var value2))
						{
							value2 = (value[key] = new Dictionary<string, string>());
						}
						value2[tileProperty.Name] = tileProperty.Value;
					}
				}
			}
		}
		if (_tileProperties.TryGetValue(layerName, out var value3) && value3.TryGetValue(new Point(relativeX, relativeY), out var value4) && value4.TryGetValue(propertyName, out var value5))
		{
			propertyValue = value5;
			return true;
		}
		return false;
	}
}
