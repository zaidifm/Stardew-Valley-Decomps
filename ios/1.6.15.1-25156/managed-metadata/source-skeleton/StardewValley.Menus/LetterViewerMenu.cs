using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class LetterViewerMenu : IClickableMenu
{
	public const int region_backButton = 101;

	public const int region_forwardButton = 102;

	public const int region_acceptQuestButton = 103;

	public const int region_itemGrabButton = 104;

	public int letterWidth;

	public int letterHeight;

	private float widthMod;

	private float heightMod;

	public Texture2D letterTexture;

	public Texture2D secretNoteImageTexture;

	public int moneyIncluded;

	public int secretNoteImage;

	public int whichBG;

	public string questID;

	public string specialOrderId;

	public string learnedRecipe;

	public string cookingOrCrafting;

	public string mailTitle;

	public List<string> mailMessage;

	public int page;

	public readonly List<ClickableComponent> itemsToGrab;

	public float scale;

	public bool isMail;

	public bool isFromCollection;

	public new bool destroy;

	public Color? customTextColor;

	public bool usingCustomBackground;

	public ClickableTextureComponent backButton;

	public ClickableTextureComponent forwardButton;

	public ClickableComponent acceptQuestButton;

	public const float scaleChange = 0.003f;

	public bool HasQuestOrSpecialOrder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LetterViewerMenu(string text)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LetterViewerMenu(int secretNoteIndex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LetterViewerMenu(string mail, string mailTitle, bool fromCollection = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string HandleActionCommand(string mail)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string HandleItemCommand(string mail)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string ApplyCustomFormatting(string text)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ShouldPlayExitSound()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool itemsLeftToGrab()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AcceptQuest()
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
	public virtual Color? getTextColor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ShouldShowInteractable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool HasInteractable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void unload()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void cleanupBeforeExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setMobilePositions()
	{
	}
}
