using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Locations;

namespace StardewValley.Objects;

public class BreakableContainer : Object
{
	public const string barrelId = "118";

	public const string frostBarrelId = "120";

	public const string darkBarrelId = "122";

	public const string desertBarrelId = "124";

	public const string volcanoBarrelId = "174";

	public const string waterBarrelId = "262";

	[XmlElement("debris")]
	private readonly NetInt debris;

	private new int shakeTimer;

	[XmlElement("health")]
	private new readonly NetInt health;

	[XmlElement("hitSound")]
	private readonly NetString hitSound;

	[XmlElement("breakSound")]
	private readonly NetString breakSound;

	[XmlElement("breakDebrisSource")]
	private readonly NetRectangle breakDebrisSource;

	[XmlElement("breakDebrisSource2")]
	private readonly NetRectangle breakDebrisSource2;

	public override string TypeDefinitionId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BreakableContainer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BreakableContainer(Vector2 tile, string itemId, int health = 3, int debrisType = 12, string hitSound = "woodWhack", string breakSound = "barrelBreak")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BreakableContainer GetBarrelForMines(Vector2 tile, MineShaft mine)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BreakableContainer GetBarrelForVolcanoDungeon(Vector2 tile)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performToolAction(Tool t)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool onExplosion(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color GetChipColor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void releaseContents(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)
	{
	}
}
