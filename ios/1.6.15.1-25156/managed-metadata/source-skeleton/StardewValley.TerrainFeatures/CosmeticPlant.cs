using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.TerrainFeatures;

public class CosmeticPlant : Grass
{
	[XmlElement("flipped")]
	public readonly NetBool flipped;

	[XmlElement("xOffset")]
	private readonly NetInt xOffset;

	[XmlElement("yOffset")]
	private readonly NetInt yOffset;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CosmeticPlant()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CosmeticPlant(int which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Rectangle getBoundingBox()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string textureName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void loadSprite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performToolAction(Tool t, int explosion, Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch)
	{
	}
}
