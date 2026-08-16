using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.GameData.FloorsAndPaths;

namespace StardewValley.TerrainFeatures;

public class Flooring : TerrainFeature
{
	private struct NeighborLoc
	{
		public readonly Vector2 Offset;

		public readonly byte Direction;

		public readonly byte InvDirection;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NeighborLoc(Vector2 a, byte b, byte c)
		{
		}
	}

	private struct Neighbor
	{
		public readonly Flooring feature;

		public readonly byte direction;

		public readonly byte invDirection;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Neighbor(Flooring a, byte b, byte c)
		{
		}
	}

	public const byte N = 1;

	public const byte E = 2;

	public const byte S = 4;

	public const byte W = 8;

	public const byte NE = 16;

	public const byte NW = 32;

	public const byte SE = 64;

	public const byte SW = 128;

	public const byte Cardinals = 15;

	public static readonly Vector2 N_Offset;

	public static readonly Vector2 E_Offset;

	public static readonly Vector2 S_Offset;

	public static readonly Vector2 W_Offset;

	public static readonly Vector2 NE_Offset;

	public static readonly Vector2 NW_Offset;

	public static readonly Vector2 SE_Offset;

	public static readonly Vector2 SW_Offset;

	public const string wood = "0";

	public const string stone = "1";

	public const string ghost = "2";

	public const string iceTile = "3";

	public const string straw = "4";

	public const string gravel = "5";

	public const string boardwalk = "6";

	public const string colored_cobblestone = "7";

	public const string cobblestone = "8";

	public const string steppingStone = "9";

	public const string brick = "10";

	public const string plankFlooring = "11";

	public const string townFlooring = "12";

	[XmlIgnore]
	public Texture2D floorTexture;

	[XmlIgnore]
	public Texture2D floorTextureWinter;

	[InstancedStatic]
	public static Dictionary<byte, int> drawGuide;

	[InstancedStatic]
	public static List<int> drawGuideList;

	[XmlElement("whichFloor")]
	public readonly NetString whichFloor;

	[XmlElement("whichView")]
	public readonly NetInt whichView;

	private byte neighborMask;

	protected static Dictionary<string, string> _FloorPathItemLookup;

	private static readonly NeighborLoc[] _offsets;

	private List<Neighbor> _neighbors;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Flooring()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Flooring(string which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ApplyFlooringFlags()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, string> GetFloorPathItemLookup()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FloorPathData GetData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetData(string id, out FloorPathData data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static void LoadFloorPathItemLookup()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Rectangle getBoundingBox()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void populateDrawGuide()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void loadSprite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void doCollisionAction(Rectangle positionOfCollider, int speedOfCollision, Vector2 tileLocation, Character who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isPassable(Character c = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getFootstepSound()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point GetTextureCorner(bool useSeasonalVariants = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Texture2D GetTexture(bool useSeasonalVariants = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShouldDrawWinterVersion()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performToolAction(Tool t, int damage, Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawInMenu(SpriteBatch spriteBatch, Vector2 positionOnScreen, Vector2 tileLocation, float scale, float layerDepth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool tickUpdate(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<Neighbor> gatherNeighbors()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAdded(GameLocation loc, Vector2 tilePos)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRemoved()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnNeighborAdded(byte direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnNeighborRemoved(byte direction)
	{
	}
}
