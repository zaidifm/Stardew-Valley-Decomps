using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class ProfileItem
{
	protected ProfileMenu _context;

	public string itemName;

	protected Vector2 _nameDrawPosition;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ProfileItem(ProfileMenu context, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Unload()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void performHover(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float HandleLayout(float draw_y, Rectangle content_rectangle)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawItemName(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawItem(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ShouldDraw()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
