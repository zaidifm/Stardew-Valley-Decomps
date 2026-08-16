using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class TailorRecipeListTool : IClickableMenu
{
	public Rectangle scrollView;

	public List<ClickableTextureComponent> recipeComponents;

	public ClickableTextureComponent okButton;

	public float scrollY;

	public Dictionary<string, KeyValuePair<Item, Item>> _recipeLookup;

	public Item hoveredItem;

	public string hoverText;

	public Dictionary<string, string> _recipeHoverTexts;

	public Dictionary<string, string> _recipeOutputIds;

	public Dictionary<string, Color> _recipeColors;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TailorRecipeListTool()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RepositionElements()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RepositionScrollElements()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveScrollWheelAction(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool canLeaveMenu()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
