using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.GameData;

namespace StardewValley;

public class TemporaryAnimatedSprite
{
	public delegate void endBehavior(int extraInfo);

	public const int FireworkType_Heart = 0;

	public const int FireworkType_Star = 1;

	public const int FireworkType_Junimo = 2;

	public static float[] FireworksLifetimeMultiplier;

	public static Color[] FireworksColors;

	public static Vector2[][] FireworksLights;

	public static Vector2[][] FireworksPoints;

	public float timer;

	public float interval;

	public int currentParentTileIndex;

	public int oldCurrentParentTileIndex;

	public int initialParentTileIndex;

	public int totalNumberOfLoops;

	public int currentNumberOfLoops;

	public int xStopCoordinate;

	public int yStopCoordinate;

	public int animationLength;

	public int bombRadius;

	public int pingPongMotion;

	public int bombDamage;

	public int fireworkType;

	public bool flicker;

	public bool timeBasedMotion;

	public bool overrideLocationDestroy;

	public bool pingPong;

	public bool holdLastFrame;

	public bool pulse;

	public int extraInfoForEndBehavior;

	public string lightId;

	public int id;

	public bool bigCraftable;

	public bool swordswipe;

	public bool flash;

	public bool flipped;

	public bool verticalFlipped;

	public bool local;

	public bool hasLit;

	public bool xPeriodic;

	public bool yPeriodic;

	public bool destroyable;

	public bool paused;

	public bool stopAcceleratingWhenVelocityIsZero;

	public bool positionFollowsAttachedCharacter;

	public bool usePreciseTiming;

	public float rotation;

	public float alpha;

	public float alphaFade;

	public float layerDepth;

	public float scale;

	public float scaleChange;

	public float scaleChangeChange;

	public float rotationChange;

	public float lightRadius;

	public float xPeriodicRange;

	public float yPeriodicRange;

	public float xPeriodicLoopTime;

	public float yPeriodicLoopTime;

	public float shakeIntensityChange;

	public float shakeIntensity;

	public float pulseTime;

	public float pulseAmount;

	public float alphaFadeFade;

	public int lightFade;

	public float afterAccelStopMotionX;

	public float afterAccelStopMotionY;

	public float layerDepthOffset;

	public Vector2 position;

	public Vector2 sourceRectStartingPos;

	protected GameLocation parent;

	public string textureName;

	public Texture2D texture;

	public Rectangle sourceRect;

	public Color color;

	public Color lightcolor;

	public Farmer owner;

	public Vector2 motion;

	public Vector2 acceleration;

	public Vector2 accelerationChange;

	public Vector2 initialPosition;

	public Vector2 vectorScale;

	public int delayBeforeAnimationStart;

	public int ticksBeforeAnimationStart;

	public string startSound;

	public string endSound;

	public string text;

	public endBehavior endFunction;

	public endBehavior reachedStopCoordinate;

	public Action<TemporaryAnimatedSprite> reachedStopCoordinateSprite;

	public TemporaryAnimatedSprite parentSprite;

	public Character attachedCharacter;

	private float pulseTimer;

	private float originalScale;

	public bool drawAboveAlwaysFront;

	public bool dontClearOnAreaEntry;

	private Stopwatch stopWatch;

	private long previousStopwatchTime;

	protected bool _pooled;

	public static List<TemporaryAnimatedSprite> _pool;

	private float totalTimer;

	public bool Pooled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Vector2 Position
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

	public Texture2D Texture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public GameLocation Parent
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float GetFireworkLifetimeMultiplier(int id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color GetFireworkColor(int id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector2[] GetFireworkLights(int id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector2[] GetFireworkPoints(int id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TemporaryAnimatedSprite getClone()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Pool()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TemporaryAnimatedSprite GetTemporaryAnimatedSprite()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TemporaryAnimatedSprite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TemporaryAnimatedSprite GetTemporaryAnimatedSprite(int initialParentTileIndex, float animationInterval, int animationLength, int numberOfLoops, Vector2 position, bool flicker, bool flipped)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TemporaryAnimatedSprite(int initialParentTileIndex, float animationInterval, int animationLength, int numberOfLoops, Vector2 position, bool flicker, bool flipped)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TemporaryAnimatedSprite GetTemporaryAnimatedSprite(int rowInAnimationTexture, Vector2 position, Color color, int animationLength = 8, bool flipped = false, float animationInterval = 100f, int numberOfLoops = 0, int sourceRectWidth = -1, float layerDepth = -1f, int sourceRectHeight = -1, int delay = 0)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TemporaryAnimatedSprite(int rowInAnimationTexture, Vector2 position, Color color, int animationLength = 8, bool flipped = false, float animationInterval = 100f, int numberOfLoops = 0, int sourceRectWidth = -1, float layerDepth = -1f, int sourceRectHeight = -1, int delay = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TemporaryAnimatedSprite GetTemporaryAnimatedSprite(int initialParentTileIndex, float animationInterval, int animationLength, int numberOfLoops, Vector2 position, bool flicker, bool flipped, bool verticalFlipped, float rotation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TemporaryAnimatedSprite(int initialParentTileIndex, float animationInterval, int animationLength, int numberOfLoops, Vector2 position, bool flicker, bool flipped, bool verticalFlipped, float rotation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TemporaryAnimatedSprite GetTemporaryAnimatedSprite(int initialParentTileIndex, float animationInterval, int animationLength, int numberOfLoops, Vector2 position, bool flicker, bool bigCraftable, bool flipped)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TemporaryAnimatedSprite(int initialParentTileIndex, float animationInterval, int animationLength, int numberOfLoops, Vector2 position, bool flicker, bool bigCraftable, bool flipped)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TemporaryAnimatedSprite GetTemporaryAnimatedSprite(string textureName, Rectangle sourceRect, float animationInterval, int animationLength, int numberOfLoops, Vector2 position, bool flicker, bool flipped)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TemporaryAnimatedSprite(string textureName, Rectangle sourceRect, float animationInterval, int animationLength, int numberOfLoops, Vector2 position, bool flicker, bool flipped)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TemporaryAnimatedSprite GetTemporaryAnimatedSprite(string textureName, Rectangle sourceRect, float animationInterval, int animationLength, int numberOfLoops, Vector2 position, bool flicker, bool flipped, float layerDepth, float alphaFade, Color color, float scale, float scaleChange, float rotation, float rotationChange, bool local = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TemporaryAnimatedSprite(string textureName, Rectangle sourceRect, float animationInterval, int animationLength, int numberOfLoops, Vector2 position, bool flicker, bool flipped, float layerDepth, float alphaFade, Color color, float scale, float scaleChange, float rotation, float rotationChange, bool local = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CopyAppearanceFromItemId(string itemId, int offset = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TemporaryAnimatedSprite GetTemporaryAnimatedSprite(string textureName, Rectangle sourceRect, Vector2 position, bool flipped, float alphaFade, Color color)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TemporaryAnimatedSprite(string textureName, Rectangle sourceRect, Vector2 position, bool flipped, float alphaFade, Color color)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TemporaryAnimatedSprite GetTemporaryAnimatedSprite(int initialParentTileIndex, float animationInterval, int animationLength, int numberOfLoops, Vector2 position, bool flicker, bool flipped, GameLocation parent, Farmer owner)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TemporaryAnimatedSprite(int initialParentTileIndex, float animationInterval, int animationLength, int numberOfLoops, Vector2 position, bool flicker, bool flipped, GameLocation parent, Farmer owner)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void loadTexture()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(BinaryReader reader, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkDirty<T>(BitArray dirtyBits, ref int i, T value, T defaultValue = default(T))
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(BinaryWriter writer, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch spriteBatch, bool localPosition = false, int xOffset = 0, int yOffset = 0, float extraAlpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void bounce(int extraInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void unload()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void reset()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetEnd()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool update(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool clearOnAreaEntry()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setSourceRectToCurrentTileIndex()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlaySound(string sound)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TemporaryAnimatedSprite CreateFromData(TemporaryAnimatedSpriteDefinition temporarySprite, float x, float y, float sortLayer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
