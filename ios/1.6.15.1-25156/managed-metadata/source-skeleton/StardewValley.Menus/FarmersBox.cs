using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

internal class FarmersBox : IClickableMenu
{
	private readonly List<Farmer> _farmers;

	public float _updateTimer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarmersBox()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateFarmers(List<ClickableComponent> parentComponents)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b, int left, int bottom, ClickableComponent current, List<ClickableComponent> parentComponents)
	{
	}
}
