using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.GameData.WildTrees;

namespace StardewValley.TerrainFeatures;

public class Tree : TerrainFeature
{
	protected static Dictionary<string, WildTreeData> _WildTreeData;

	protected static Dictionary<string, List<string>> _WildTreeSeedLookup;

	public const float chanceForDailySeed = 0.05f;

	public const float shakeRate = (float)Math.PI / 200f;

	public const float shakeDecayRate = 0.0030679617f;

	public const int minWoodDebrisForFallenTree = 12;

	public const int minWoodDebrisForStump = 5;

	public const int startingHealth = 10;

	public const int leafFallRate = 3;

	public const int stageForMossGrowth = 14;

	public const string bushyTree = "1";

	public const string leafyTree = "2";

	public const string pineTree = "3";

	public const string winterTree1 = "4";

	public const string winterTree2 = "5";

	public const string palmTree = "6";

	public const string mushroomTree = "7";

	public const string mahoganyTree = "8";

	public const string palmTree2 = "9";

	public const string greenRainTreeBushy = "10";

	public const string greenRainTreeLeafy = "11";

	public const string greenRainTreeFern = "12";

	public const string mysticTree = "13";

	public const int seedStage = 0;

	public const int sproutStage = 1;

	public const int saplingStage = 2;

	public const int bushStage = 3;

	public const int treeStage = 5;

	[XmlIgnore]
	public Lazy<Texture2D> texture;

	protected Season? localSeason;

	[XmlElement("growthStage")]
	public readonly NetInt growthStage;

	[XmlElement("treeType")]
	public readonly NetString treeType;

	[XmlElement("health")]
	public readonly NetFloat health;

	[XmlElement("flipped")]
	public readonly NetBool flipped;

	[XmlElement("stump")]
	public readonly NetBool stump;

	[XmlElement("tapped")]
	public readonly NetBool tapped;

	[XmlElement("hasSeed")]
	public readonly NetBool hasSeed;

	[XmlElement("hasMoss")]
	public readonly NetBool hasMoss;

	[XmlElement("isTemporaryGreenRainTree")]
	public readonly NetBool isTemporaryGreenRainTree;

	[XmlIgnore]
	public readonly NetBool wasShakenToday;

	[XmlElement("fertilized")]
	public readonly NetBool fertilized;

	[XmlIgnore]
	public readonly NetBool shakeLeft;

	[XmlIgnore]
	public readonly NetBool falling;

	[XmlIgnore]
	public readonly NetBool destroy;

	[XmlIgnore]
	public float shakeRotation;

	[XmlIgnore]
	public float maxShake;

	[XmlIgnore]
	public float alpha;

	private List<Leaf> leaves;

	[XmlIgnore]
	public readonly NetLong lastPlayerToHit;

	[XmlIgnore]
	public float shakeTimer;

	[XmlElement("stopGrowingMoss")]
	public readonly NetBool stopGrowingMoss;

	public static Rectangle treeTopSourceRect;

	public static Rectangle stumpSourceRect;

	public static Rectangle shadowSourceRect;

	[XmlIgnore]
	public string TextureName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Tree()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Tree(string id, int growthStage, bool isGreenRainTemporaryTree = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Tree(string id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, WildTreeData> GetWildTreeDataDictionary()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, List<string>> GetWildTreeSeedLookup()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static void _LoadWildTreeData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ResolveTreeTypeFromSeed(string itemId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ClearCache()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckForNewTexture()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetTexture()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WildTreeData GetData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetData(string id, out WildTreeData data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected string ChooseTexture()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Rectangle getBoundingBox()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Rectangle getRenderBounds()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performUseAction(Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int extraWoodCalculator(Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool tickUpdate(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item TryGetDrop(WildTreeItemData drop, Random r, Farmer targetFarmer, string fieldName, Func<string, string> formatItemId = null, bool? isStump = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void shake(Vector2 tileLocation, bool doEvenIfStillShaking)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isPassable(Character c = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetMaxSizeHere(bool ignoreSeason = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsInSeason()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsGrowthBlockedByNearbyTree()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void onGreenRainDay(bool undo = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void dayUpdate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performPlayerEntryAction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool seasonUpdate(bool onLoad)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isActionable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsLeafy()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color? GetChopDebrisColor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color? GetChopDebrisColor(WildTreeData data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performToolAction(Tool t, int explosion, Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item CreateMossItem()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool fertilize()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool instantDestroy(Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void performSeedDestroy(Tool t, Vector2 tileLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateTapperProduct(Object tapper, Object previousOutput = null, bool onlyPerformRemovals = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool TryGetTapperOutput(List<WildTreeTapItemData> tapItems, string previousItemId, Random r, float timeMultiplier, out Object output, out int minutesUntilReady)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void performSproutDestroy(Tool t, Vector2 tileLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void performBushDestroy(Vector2 tileLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool performTreeFall(Tool t, int explosion, Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void setSeason()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawInMenu(SpriteBatch spriteBatch, Vector2 positionOnScreen, Vector2 tileLocation, float scale, float layerDepth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch)
	{
	}
}
