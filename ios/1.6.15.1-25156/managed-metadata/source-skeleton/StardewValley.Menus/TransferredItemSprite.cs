using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class TransferredItemSprite
{
	public Item item;

	public Vector2 position;

	public float age;

	public float alpha;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TransferredItemSprite(Item transferred_item, int start_x, int start_y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Update(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw(SpriteBatch b)
	{
	}
}
