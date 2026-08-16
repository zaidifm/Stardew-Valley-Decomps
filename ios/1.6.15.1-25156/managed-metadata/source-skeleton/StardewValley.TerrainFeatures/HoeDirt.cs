using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Objects;

namespace StardewValley.TerrainFeatures;

public class HoeDirt : TerrainFeature
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
		public readonly HoeDirt feature;

		public readonly byte direction;

		public readonly byte invDirection;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Neighbor(HoeDirt a, byte b, byte c)
		{
		}
	}

	public const float defaultShakeRate = (float)Math.PI / 80f;

	public const float maximumShake = (float)Math.PI / 8f;

	public const float shakeDecayRate = (float)Math.PI / 300f;

	public const byte N = 1;

	public const byte E = 2;

	public const byte S = 4;

	public const byte W = 8;

	public const byte Cardinals = 15;

	public static readonly Vector2 N_Offset;

	public static readonly Vector2 E_Offset;

	public static readonly Vector2 S_Offset;

	public static readonly Vector2 W_Offset;

	public const float paddyGrowBonus = 0.25f;

	public const int dry = 0;

	public const int watered = 1;

	public const int invisible = 2;

	public const string fertilizerLowQualityID = "368";

	public const string fertilizerHighQualityID = "369";

	public const string waterRetentionSoilID = "370";

	public const string waterRetentionSoilQualityID = "371";

	public const string speedGroID = "465";

	public const string superSpeedGroID = "466";

	public const string hyperSpeedGroID = "918";

	public const string fertilizerDeluxeQualityID = "919";

	public const string waterRetentionSoilDeluxeID = "920";

	public const string fertilizerLowQualityQID = "(O)368";

	public const string fertilizerHighQualityQID = "(O)369";

	public const string waterRetentionSoilQID = "(O)370";

	public const string waterRetentionSoilQualityQID = "(O)371";

	public const string speedGroQID = "(O)465";

	public const string superSpeedGroQID = "(O)466";

	public const string hyperSpeedGroQID = "(O)918";

	public const string fertilizerDeluxeQualityQID = "(O)919";

	public const string waterRetentionSoilDeluxeQID = "(O)920";

	public static Texture2D lightTexture;

	public static Texture2D darkTexture;

	public static Texture2D snowTexture;

	private readonly NetRef<Crop> netCrop;

	public static Dictionary<byte, int> drawGuide;

	[XmlElement("state")]
	public readonly NetInt state;

	[XmlElement("fertilizer")]
	public readonly NetString fertilizer;

	private bool shakeLeft;

	private float shakeRotation;

	private float maxShake;

	private float shakeRate;

	[XmlElement("c")]
	private readonly NetColor c;

	private List<Action<GameLocation, Vector2>> queuedActions;

	private byte neighborMask;

	private byte wateredNeighborMask;

	[XmlIgnore]
	public NetInt nearWaterForPaddy;

	private byte drawSum;

	private int sourceRectPosition;

	private int wateredRectPosition;

	private Texture2D texture;

	private static readonly NeighborLoc[] _offsets;

	private List<Neighbor> _neighbors;

	[XmlIgnore]
	public override GameLocation Location
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public override Vector2 Tile
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public Crop crop
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[XmlIgnore]
	public IndoorPot Pot
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HoeDirt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HoeDirt(int startingState, GameLocation location = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HoeDirt(int startingState, Crop crop)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void initialize(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float getShakeRotation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float getMaxShake()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Rectangle getBoundingBox()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void doCollisionAction(Rectangle positionOfCollider, int speedOfCollision, Vector2 tileLocation, Character who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void shake(float shake, float rate, bool left)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool needsWatering()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isWatered()
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
	public override bool isPassable(Character c = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool readyForHarvest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performUseAction(Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool plant(string itemId, Farmer who, bool isFertilizer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void applySpeedIncreases(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void destroyCrop(bool showAnimation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performToolAction(Tool t, int damage, Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool canPlantThisSeedHere(string itemId, bool isFertilizer = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performPlayerEntryAction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool tickUpdate(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasPaddyCrop()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool paddyWaterCheck(bool forceUpdate = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void dayUpdate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool seasonUpdate(bool onLoad)
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
	public void DrawOptimized(SpriteBatch dirt_batch, SpriteBatch fert_batch, SpriteBatch crop_batch)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool HasFertilizer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanApplyFertilizer(string fertilizerId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual HoeDirtFertilizerApplyStatus CheckApplyFertilizerRules(string fertilizerId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float GetFertilizerSpeedBoost()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float GetFertilizerWaterRetentionChance()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetFertilizerQualityBoostLevel()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Rectangle GetFertilizerSourceRect()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<Neighbor> gatherNeighbors()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateNeighbors()
	{
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
	public virtual void UpdateDrawSums()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnNeighborAdded(byte direction, int neighborState)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnNeighborRemoved(byte direction)
	{
	}
}
