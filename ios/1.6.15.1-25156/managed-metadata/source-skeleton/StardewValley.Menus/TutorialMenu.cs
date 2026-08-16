using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class TutorialMenu : IClickableMenu
{
	public const int constructionTab = 4;

	public const int friendshipTab = 5;

	public const int townTab = 6;

	public const int animalsTab = 7;

	private int currentTab;

	private List<ClickableTextureComponent> topics;

	private ClickableTextureComponent backButton;

	private ClickableTextureComponent okButton;

	private List<ClickableTextureComponent> icons;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TutorialMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
