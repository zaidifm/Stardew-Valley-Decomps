using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class PI_ItemList : ProfileItem
{
	protected List<Item> _items;

	protected List<ClickableTextureComponent> _components;

	protected float _height;

	protected List<Vector2> _emptyBoxPositions;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PI_ItemList(ProfileMenu context, string name, List<Item> values)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Unload()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _ClearItems()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _UpdateIcons()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override float HandleLayout(float draw_y, Rectangle content_rectangle)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DrawItem(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHover(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ShouldDraw()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
