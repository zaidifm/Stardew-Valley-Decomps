using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.Objects;

public class ColoredObject : Object
{
	[XmlElement("color")]
	public readonly NetColor color;

	[XmlElement("colorSameIndexAsParentSheetIndex")]
	public readonly NetBool colorSameIndexAsParentSheetIndex;

	public bool ColorSameIndexAsParentSheetIndex
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
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ColoredObject()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ColoredObject(string itemId, int stack, Color color)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color colorOverride, bool drawShadow)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void drawSmokedFish(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float layerDepth, float transparency = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawWhenHeld(SpriteBatch spriteBatch, Vector2 objectPosition, Farmer f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetHue()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Item GetOneNew()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void GetOneCopyFrom(Item source)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TrySetColor(Item input, Color color, out ColoredObject coloredItem)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
