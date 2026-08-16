using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class SkillsPage : IClickableMenu
{
	public const int region_special1 = 10201;

	public const int region_special2 = 10202;

	public const int region_special3 = 10203;

	public const int region_special4 = 10204;

	public const int region_special5 = 10205;

	public const int region_special6 = 10206;

	public const int region_special7 = 10207;

	public const int region_special8 = 10208;

	public const int region_special9 = 10209;

	public const int region_skillArea1 = 0;

	public const int region_skillArea2 = 1;

	public const int region_skillArea3 = 2;

	public const int region_skillArea4 = 3;

	public const int region_skillArea5 = 4;

	public List<ClickableTextureComponent> skillBars;

	public List<ClickableTextureComponent> skillAreas;

	public List<ClickableTextureComponent> specialItems;

	private string hoverText;

	private string hoverTitle;

	private int professionImage;

	private int playerPanelIndex;

	private int playerPanelTimer;

	private Rectangle playerPanel;

	private int[] playerPanelFrames;

	private int timesClickedJunimo;

	private int portraitX;

	private const int portraitY = 80;

	private const int walletX = 30;

	private const int walletY = 480;

	private const int walletHeight = 130;

	private const int iconsX = 600;

	private const int iconsY = 90;

	private const int portraitTextXAddon = 64;

	private const int portraitTextYAddon = 192;

	private const int offset = 16;

	private float widthMod;

	private float heightMod;

	private string walletText;

	private string headerText;

	private string specialText;

	private Vector2 specialTextSize;

	private Vector2 walletTextSize;

	private ClickableTextureComponent hoverItem;

	private ClickableTextureComponent currentSkillbar;

	private float hoverTime;

	private bool showTooltip;

	private bool showProfession;

	private bool showProficiency;

	private Rectangle hoverBox;

	private int _selectedSpecialItemIndex;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SkillsPage(int x, int y, int width, int height, float wMod, float hMod)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void parseProfessionDescription(ref string professionBlurb, ref string professionTitle, List<string> professionDescription)
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
	public override void receiveRightClick(int x, int y, bool playSound = true)
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSpecialItemTooltip(ClickableTextureComponent c)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSkillBarTooltip(ClickableTextureComponent c)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSkillAreaTooltip(ClickableTextureComponent c)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HideTooltip()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons b)
	{
	}
}
