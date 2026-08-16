using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using Netcode.Validation;

namespace StardewValley.TerrainFeatures;

[NotImplicitNetField]
[XmlInclude(typeof(CosmeticPlant))]
public class Grass : TerrainFeature
{
	public const float defaultShakeRate = (float)Math.PI / 80f;

	public const float maximumShake = (float)Math.PI / 8f;

	public const float shakeDecayRate = (float)Math.PI / 350f;

	public const byte springGrass = 1;

	public const byte caveGrass = 2;

	public const byte frostGrass = 3;

	public const byte lavaGrass = 4;

	public const byte caveGrass2 = 5;

	public const byte cobweb = 6;

	public const byte blueGrass = 7;

	public static ICue grassSound;

	[XmlElement("grassType")]
	public readonly NetByte grassType;

	private bool shakeLeft;

	protected float shakeRotation;

	protected float maxShake;

	protected float shakeRate;

	[XmlElement("numberOfWeeds")]
	public readonly NetInt numberOfWeeds;

	[XmlElement("grassSourceOffset")]
	public readonly NetInt grassSourceOffset;

	private int grassBladeHealth;

	[XmlIgnore]
	public Lazy<Texture2D> texture;

	private int[] whichWeed;

	private int[] offset1;

	private int[] offset2;

	private int[] offset3;

	private int[] offset4;

	private bool[] flip;

	private double[] shakeRandom;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Grass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Grass(int which, int numberOfWeeds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PlayGrassSound()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string textureName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isPassable(Character c = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void loadSprite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnAddedToLocation(GameLocation location, Vector2 tile)
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
	public override void doCollisionAction(Rectangle positionOfCollider, int speedOfCollision, Vector2 tileLocation, Character who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool reduceBy(int number, bool showDebris)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void shake(float shake, float rate, bool left)
	{
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
	public override void dayUpdate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setUpRandom()
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
	private void createDestroySprites(GameLocation location, Vector2 tileLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryDropItemsOnCut(Tool tool, bool addAnimation = true)
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
}
