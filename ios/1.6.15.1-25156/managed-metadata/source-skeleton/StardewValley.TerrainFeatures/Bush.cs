using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Network;

namespace StardewValley.TerrainFeatures;

public class Bush : LargeTerrainFeature
{
	public const float shakeRate = (float)Math.PI / 200f;

	public const float shakeDecayRate = 0.0030679617f;

	public const int smallBush = 0;

	public const int mediumBush = 1;

	public const int largeBush = 2;

	public const int greenTeaBush = 3;

	public const int walnutBush = 4;

	public const int daysToMatureGreenTeaBush = 20;

	[XmlElement("size")]
	public readonly NetInt size;

	[XmlElement("datePlanted")]
	public readonly NetInt datePlanted;

	[XmlElement("tileSheetOffset")]
	public readonly NetInt tileSheetOffset;

	public float health;

	[XmlElement("flipped")]
	public readonly NetBool flipped;

	[XmlElement("townBush")]
	public readonly NetBool townBush;

	public readonly NetBool inPot;

	[XmlElement("drawShadow")]
	public readonly NetBool drawShadow;

	private bool shakeLeft;

	private float shakeRotation;

	private float maxShake;

	[XmlIgnore]
	public float shakeTimer;

	[XmlIgnore]
	public readonly NetRectangle sourceRect;

	[XmlIgnore]
	public NetMutex uniqueSpawnMutex;

	public static Lazy<Texture2D> texture;

	public static Rectangle shadowSourceRect;

	private float yDrawOffset;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bush()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bush(Vector2 tileLocation, int size, GameLocation location, int datePlantedOverride = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getAge()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setUpSourceRect()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool readyForHarvest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Season GetCosmeticSeason()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSheltered()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool inBloom()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isActionable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void loadSprite()
	{
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
	public override bool tickUpdate(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void shake(Vector2 tileLocation, bool doEvenIfStillShaking)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetShakeOffItem()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void junimoPlushCallback(Item item, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isPassable(Character c = null)
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
	public override bool performToolAction(Tool t, int explosion, Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isDestroyable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawInMenu(SpriteBatch spriteBatch, Vector2 positionOnScreen, Vector2 tileLocation, float scale, float layerDepth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performPlayerEntryAction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int getEffectiveSize()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch spriteBatch, float yDrawOffset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch)
	{
	}
}
