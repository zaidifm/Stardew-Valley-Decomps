using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Network;

namespace StardewValley;

public class Debris : INetObject<NetFields>
{
	public enum DebrisType
	{
		CHUNKS = 0,
		LETTERS = 1,
		ARCHAEOLOGY = 3,
		OBJECT = 4,
		SPRITECHUNKS = 5,
		RESOURCE = 6,
		NUMBERS = 7
	}

	public const int copperDebris = 0;

	public const int ironDebris = 2;

	public const int coalDebris = 4;

	public const int goldDebris = 6;

	public const int coinsDebris = 8;

	public const int iridiumDebris = 10;

	public const int woodDebris = 12;

	public const int stoneDebris = 14;

	public const int bigStoneDebris = 32;

	public const int bigWoodDebris = 34;

	public const int timesToBounce = 2;

	public const float gravity = 0.4f;

	public const float timeToWaitBeforeRemoval = 600f;

	public const int marginForChunkPickup = 64;

	public const int white = 10000;

	public const int green = 100001;

	public const int blue = 100002;

	public const int red = 100003;

	public const int yellow = 100004;

	public const int black = 100005;

	public const int charcoal = 100007;

	public const int gray = 100006;

	private float relativeXPosition;

	private readonly NetObjectShrinkList<Chunk> chunks;

	public readonly NetInt chunkType;

	public readonly NetInt sizeOfSourceRectSquares;

	private readonly NetInt netItemQuality;

	private readonly NetInt netChunkFinalYLevel;

	private readonly NetInt netChunkFinalYTarget;

	public float timeSinceDoneBouncing;

	public readonly NetFloat scale;

	protected NetBool _chunksMoveTowardsPlayer;

	public readonly NetLong DroppedByPlayerID;

	private bool movingUp;

	public readonly NetBool floppingFish;

	public bool isFishable;

	public bool movingFinalYLevel;

	public readonly NetEnum<DebrisType> debrisType;

	public readonly NetBool isSinking;

	public readonly NetString debrisMessage;

	public readonly NetColor nonSpriteChunkColor;

	public readonly NetColor chunksColor;

	private float animationTimer;

	private int timeBeforeReturnToDroppingPlayer;

	public readonly NetString spriteChunkSheetName;

	private Texture2D _spriteChunkSheet;

	public readonly NetString itemId;

	private readonly NetRef<Item> netItem;

	public Character toHover;

	public readonly NetFarmerRef player;

	public int itemQuality
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

	public int chunkFinalYLevel
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

	public int chunkFinalYTarget
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

	public bool chunksMoveTowardPlayer
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

	public Texture2D spriteChunkSheet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Item item
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

	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public NetObjectShrinkList<Chunk> Chunks
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Debris()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Debris(int debris_type, Vector2 debrisOrigin, Vector2 playerPosition)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Debris(int resource_type, int numberOfChunks, Vector2 debrisOrigin, Vector2 playerPosition, float velocityMultiplyer = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Debris(int debrisType, int numberOfChunks, Vector2 debrisOrigin, Vector2 playerPosition, int groundLevel, Color? color = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Debris(string item_id, Vector2 debrisOrigin, Vector2 playerPosition)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Debris(string item_id, int numberOfChunks, Vector2 debrisOrigin, Vector2 playerPosition, float velocityMultiplyer = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitializeItem(string item_id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitializeResource(int item_id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Debris(Item item, Vector2 debrisOrigin)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Debris(Item item, Vector2 debrisOrigin, Vector2 targetLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Debris(int number, Vector2 debrisOrigin, Color messageColor, float scale, Character toHover)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Debris(string message, int numberOfChunks, Vector2 debrisOrigin, Color messageColor, float scale, float rotation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Debris(string spriteSheet, int numberOfChunks, Vector2 debrisOrigin)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Debris(string spriteSheet, Rectangle sourceRect, int numberOfChunks, Vector2 debrisOrigin)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Debris(string spriteSheet, Rectangle sourceRect, int numberOfChunks, Vector2 debrisOrigin, Vector2 playerPosition, int groundLevel, int sizeOfSourceRectSquares)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Debris(string spriteSheet, Rectangle sourceRect, int numberOfChunks, Vector2 debrisOrigin, Vector2 playerPosition, int groundLevel)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isEssentialItem()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool collect(Farmer farmer, Chunk chunk = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color getColorForDebris(int type)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitializeChunks(int numberOfChunks, Vector2 debrisOrigin, Vector2 playerPosition, float velocityMultiplyer = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector2 approximatePosition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool playerInRange(Vector2 position, Farmer farmer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Farmer findBestPlayer(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool shouldControlThis(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool updateChunks(GameTime time, GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateHoverPosition(Chunk chunk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getNameOfDebrisTypeFromIntId(int id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
