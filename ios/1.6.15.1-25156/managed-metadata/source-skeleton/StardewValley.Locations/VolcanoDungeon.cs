using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Monsters;
using StardewValley.Network;
using StardewValley.Objects;
using xTile.Dimensions;
using xTile.Layers;

namespace StardewValley.Locations;

public class VolcanoDungeon : IslandLocation
{
	public enum TileNeighbors
	{
		N = 1,
		S = 2,
		E = 4,
		W = 8,
		NW = 0x10,
		NE = 0x20
	}

	private const int coalIndexPlaceholder = 1095382;

	private const string coalIndexPlaceholderString = "1095382";

	public const string MainTileSheetId = "dungeon";

	public NetInt level;

	public NetEvent1Field<Point, NetPoint> coolLavaEvent;

	public static List<VolcanoDungeon> activeLevels;

	public NetVector2Dictionary<bool, NetBool> cooledLavaTiles;

	public Dictionary<Vector2, Point> localCooledLavaTiles;

	public HashSet<Point> dirtTiles;

	public NetInt generationSeed;

	public NetInt layoutIndex;

	public Random generationRandom;

	private LocalizedContentManager mapContent;

	[XmlIgnore]
	public int mapWidth;

	[XmlIgnore]
	public int mapHeight;

	public const int WALL_HEIGHT = 4;

	public Layer backLayer;

	public Layer buildingsLayer;

	public Layer frontLayer;

	public Layer alwaysFrontLayer;

	[XmlIgnore]
	public Point? startPosition;

	[XmlIgnore]
	public Point? endPosition;

	public const int LAYOUT_WIDTH = 64;

	public const int LAYOUT_HEIGHT = 64;

	[XmlIgnore]
	public Texture2D mapBaseTilesheet;

	public static List<Microsoft.Xna.Framework.Rectangle> setPieceAreas;

	internal static Dictionary<int, Point> _blobIndexLookup;

	internal static Dictionary<int, Point> _lavaBlobIndexLookup;

	protected bool generated;

	[NonInstancedStatic]
	protected static Point shortcutOutPosition;

	[XmlIgnore]
	protected NetBool shortcutOutUnlocked;

	[XmlIgnore]
	protected NetBool bridgeUnlocked;

	public Color[] pixelMap;

	public int[] heightMap;

	public Dictionary<int, List<Point>> possibleSwitchPositions;

	public Dictionary<int, List<Point>> possibleGatePositions;

	public NetList<DwarfGate, NetRef<DwarfGate>> dwarfGates;

	[XmlIgnore]
	protected bool _sawFlameSprite;

	private int lavaSoundsPlayedThisTick;

	private float steamTimer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VolcanoDungeon()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VolcanoDungeon(int level)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool BlocksDamageLOS(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override LocalizedContentManager getMapLoader()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanPlaceThisFurnitureHere(Furniture furniture)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnCoolLavaEvent(Point point)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CoolLava(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateLavaNeighbor(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsCooledLava(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool answerDialogueAction(string questionAndAnswer, string[] questionParams)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UseVolcanoShortcut()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GenerateContents(bool use_level_level_as_layout = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isMushroomLevel()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isMonsterLevel()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void checkForMusic(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateShortcutOut()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateBridge()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string GetLocationSpecificMusic()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetSharedState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanRefillWateringCanOnTile(int tileX, int tileY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GenerateLevel(bool use_level_level_as_layout = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GenerateDirtTiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreateEntrance(Point? position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateExit(Point? position, bool draw_stairs = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ErodeInvalidDirtTiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void monsterDrop(Monster monster, int x, int y, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point? GetDirtNeighborTile(int tile_x, int tile_y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreateDwarfGate(int gate_index, Point tile_position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddPossibleSwitchLocation(int switch_index, int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddPossibleGateLocation(int gate_index, int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void adjustLevelChances(ref double stoneChance, ref double monsterChance, ref double itemChance, ref double gemStoneChance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTileClearForMineObjects(Vector2 v, bool ignoreRuins = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTileOnClearAndSolidGround(Vector2 v)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GenerateEntities()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Object createStone(int stone, Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int chooseStoneTypeIndexOnly(Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void tryToAddOreClumps()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ApplySetPieces()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SpawnChest(int tile_x, int tile_y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool breakStone(string stoneId, int x, int y, Farmer who, Random r)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PopulateChest(IList<Item> items, Random chest_random, int chest_type)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ApplyToColor(Color match, Action<int, int> action)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool sinkDebris(Debris debris, Vector2 chunkTile, Vector2 chunkPosition)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performToolAction(Tool t, int tileX, int tileY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GenerateBlobs(Color match, int tile_x, int tile_y, bool fill_center = true, bool is_lava_pool = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dictionary<int, Point> GetBlobLookup()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isCollidingPosition(Microsoft.Xna.Framework.Rectangle position, xTile.Dimensions.Rectangle viewport, bool isFarmer, int damagesFarmer, bool glider, Character character, bool pathfinding, bool projectile = false, bool ignoreCharacterRequirement = false, bool skipCollisionEffects = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dictionary<int, Point> GetLavaBlobLookup()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GenerateWalls(Color match, int source_x, int source_y, int wall_height = 4, int random_wall_variants = 1, bool start_in_wall = false, Action<int, int> on_insufficient_wall_height = null, bool use_corner_hack = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetPixelClearance(int x, int y, int wall_height, Color match)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlaceGroundTile(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawFloorDecorations(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawWaterTile(SpriteBatch b, int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performTenMinuteUpdate(int timeOfDay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void spawnFlyingMonsterOffScreen()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlaceSingleWall(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ApplyPixels(string layout_texture_name, int source_x = 0, int source_y = 0, int width = 64, int height = 64, int x_offset = 0, int y_offset = 0, bool flip_x = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetHeight(int x, int y, int max_height)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color GetPixel(int x, int y, Color out_of_bounds_color)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPixelMap(int x, int y, Color color)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetNeighborValue(int x, int y, Color matched_color, bool is_lava_pool = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color GetPixelColor(int width, int height, Color[] pixels, int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetTileIndex(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTile(Layer layer, int x, int y, int index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMaxRoomLayouts()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static VolcanoDungeon GetLevel(string name, bool use_level_level_as_layout = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetLevelName(int level)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsGeneratedLevel(string locationName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsGeneratedLevel(string locationName, out int level)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateLevels(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateLevels10Minutes(int timeOfDay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ClearAllLevels()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRemoved()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ForEach(Action<VolcanoDungeon> action)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ShouldExcludeFromNpcPathfinding()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performTouchAction(string[] action, Vector2 playerStandingPosition)
	{
	}
}
