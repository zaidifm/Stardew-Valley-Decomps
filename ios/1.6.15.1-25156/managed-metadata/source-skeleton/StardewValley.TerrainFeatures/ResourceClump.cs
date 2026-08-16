using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.TerrainFeatures;

[XmlInclude(typeof(GiantCrop))]
public class ResourceClump : TerrainFeature
{
	public const int greenRainBush1Index = 44;

	public const int greenRainBush2Index = 46;

	public const int stumpIndex = 600;

	public const int hollowLogIndex = 602;

	public const int meteoriteIndex = 622;

	public const int boulderIndex = 672;

	public const int mineRock1Index = 752;

	public const int mineRock2Index = 754;

	public const int mineRock3Index = 756;

	public const int mineRock4Index = 758;

	public const int quarryBoulderIndex = 148;

	[XmlElement("width")]
	public readonly NetInt width;

	[XmlElement("height")]
	public readonly NetInt height;

	[XmlElement("parentSheetIndex")]
	public readonly NetInt parentSheetIndex;

	[XmlElement("textureName")]
	public readonly NetString textureName;

	[XmlElement("health")]
	public readonly NetFloat health;

	[XmlElement("tile")]
	public readonly NetVector2 netTile;

	[XmlIgnore]
	public float shakeTimer;

	private Texture2D texture;

	private int lastToolHitTicker;

	[XmlIgnore]
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ResourceClump()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ResourceClump(int parentSheetIndex, int width, int height, Vector2 tile, int? health = null, string textureName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual int GetDefaultHealth(int parentSheetIndex)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isPassable(Character c = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsGreenRainBush()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performToolAction(Tool t, int damage, Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool destroy(Tool t, GameLocation location, Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Rectangle getBoundingBox()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool occupiesTile(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void loadSprite()
	{
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
}
