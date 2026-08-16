using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class ProfileMenu : IClickableMenu
{
	public class ProfileItemCategory
	{
		public string categoryName;

		public int[] validCategories;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ProfileItemCategory(string name, int[] valid_categories)
		{
		}
	}

	public const int region_backButton = 101;

	public const int region_forwardButton = 102;

	public int letterWidth;

	public int letterHeight;

	public Texture2D letterTexture;

	public Texture2D secretNoteImageTexture;

	protected string hoverText;

	protected List<ProfileItem> _profileItems;

	public Item hoveredItem;

	public ClickableTextureComponent backButton;

	public ClickableTextureComponent forwardButton;

	public ClickableTextureComponent nextCharacterButton;

	public ClickableTextureComponent previousCharacterButton;

	protected Rectangle characterSpriteBox;

	protected int _currentCategory;

	protected AnimatedSprite _animatedSprite;

	protected float _directionChangeTimer;

	protected float _hiddenEmoteTimer;

	protected int _currentDirection;

	protected int _hideTooltipTime;

	protected SocialPage _socialPage;

	protected string _status;

	protected string _printedName;

	protected Vector2 _characterEntrancePosition;

	public List<ClickableComponent> clickableProfileItems;

	public SocialPage.SocialEntry Current;

	public readonly List<SocialPage.SocialEntry> SocialEntries;

	protected Vector2 _characterNamePosition;

	protected Vector2 _heartDisplayPosition;

	protected Vector2 _birthdayHeadingDisplayPosition;

	protected Vector2 _birthdayDisplayPosition;

	protected Vector2 _statusHeadingDisplayPosition;

	protected Vector2 _statusDisplayPosition;

	protected Vector2 _giftLogHeadingDisplayPosition;

	protected Vector2 _giftLogCategoryDisplayPosition;

	protected Vector2 _errorMessagePosition;

	protected Vector2 _characterSpriteDrawPosition;

	protected Rectangle _characterStatusDisplayBox;

	protected List<ClickableTextureComponent> _clickableTextureComponents;

	private MobileScrollbox scrollArea;

	private Rectangle storedGiftLogRect;

	public static ProfileItemCategory[] itemCategories;

	protected Dictionary<int, List<Item>> _sortedItems;

	private bool drawBackPanel;

	private int _characterSpriteRandomInt;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ProfileMenu(SocialPage.SocialEntry subject, List<SocialPage.SocialEntry> allSocialEntries)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _SetCharacter(SocialPage.SocialEntry entry)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeCharacter(int offset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _UpdateList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateButtons()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangePage(int offset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons b)
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
	public override void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayHiddenEmote()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetupLayout()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateLayout()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void unload()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterClickable(ClickableComponent clickable)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnregisterClickable(ClickableComponent clickable)
	{
	}
}
