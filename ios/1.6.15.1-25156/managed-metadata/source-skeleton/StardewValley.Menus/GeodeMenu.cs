using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class GeodeMenu : MenuWithInventory
{
	public const int region_geodeSpot = 998;

	public ClickableComponent geodeSpot;

	public AnimatedSprite clint;

	public TemporaryAnimatedSprite geodeDestructionAnimation;

	public TemporaryAnimatedSprite sparkle;

	public int geodeAnimationTimer;

	public int yPositionOfGem;

	public int alertTimer;

	public float delayBeforeShowArtifactTimer;

	public Item geodeTreasure;

	public Item geodeTreasureOverride;

	public bool waitingForServerResponse;

	private TemporaryAnimatedSpriteList fluffSprites;

	private int _selectedItemIndex;

	private bool _showTooltip;

	private string fullText;

	private string noMoneyText;

	private string geodeText;

	private Rectangle infoBox;

	private Rectangle bottomInv;

	private float widthMod;

	private float heightMod;

	private new int width;

	private new int height;

	private int goldX;

	private int goldY;

	private int geodeX;

	private int geodeY;

	private int geodeHeight;

	private int geodeWidth;

	private int geodeCrop;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GeodeMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool highlightGeodes(Item i)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void startGeodeCrack()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
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
	public override void emergencyShutDown()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPlaceGeodeOnAnvil()
	{
	}
}
