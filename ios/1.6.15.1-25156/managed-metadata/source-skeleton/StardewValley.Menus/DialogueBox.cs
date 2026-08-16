using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class DialogueBox : IClickableMenu
{
	public List<string> dialogues;

	public Dialogue characterDialogue;

	public Stack<string> characterDialoguesBrokenUp;

	public Response[] responses;

	public const int portraitBoxSize = 74;

	public const int nameTagWidth = 102;

	public const int nameTagHeight = 18;

	public const int portraitPlateWidth = 115;

	public const int nameTagSideMargin = 5;

	public const float transitionRate = 3f;

	public const int characterAdvanceDelay = 30;

	public const int safetyDelay = 750;

	public int questionFinishPauseTimer;

	protected bool _showedOptions;

	public Rectangle friendshipJewel;

	public List<ClickableComponent> responseCC;

	private bool closeButton;

	private bool hasBeenClicked;

	private bool responseMade;

	public const int TEXT_PADDING_LEFT = 8;

	public const int TEXT_PADDING_RIGHT = 16;

	public const int TEXT_PADDING_TOP = 12;

	public const int TEXT_PADDING_BOTTOM = 12;

	public int x;

	public int y;

	public int transitionX;

	public int transitionY;

	public int transitionWidth;

	public int transitionHeight;

	public int characterAdvanceTimer;

	public int characterIndexInDialogue;

	public int safetyTimer;

	public int heightForQuestions;

	public int selectedResponse;

	public int newPortaitShakeTimer;

	public bool transitionInitialized;

	public bool showTyping;

	public bool transitioning;

	public bool transitioningBigger;

	public bool dialogueContinuedOnNextPage;

	public bool dialogueFinished;

	public bool isQuestion;

	public TemporaryAnimatedSprite dialogueIcon;

	public TemporaryAnimatedSprite aboveDialogueImage;

	public string fullDialogue;

	private string hoverText;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DialogueBox(int x, int y, int width, int height)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DialogueBox(string dialogue, bool closeButton = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DialogueBox(string dialogue, Response[] responses, int width = 1200)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DialogueBox(Dialogue dialogue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DialogueBox(List<string> dialogues)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void playOpeningSound()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void setUpForGamePadMode()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void closeDialogue()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void finishTyping()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasFinishedTyping()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void beginOutro()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tryOutro()
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
	public override void leftClickHeld(int mouseX, int mouseY)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTransitioning()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getSelectedResponse()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setUpIcons()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int mouseX, int mouseY)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setUpQuestionIcon()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setUpCloseDialogueIcon()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setUpNextPageIcon()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkDialogue(Dialogue d)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setUpQuestions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isPortraitBox()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawBox(SpriteBatch b, int xPos, int yPos, int boxWidth, int boxHeight)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool shouldPortraitShake(Dialogue d)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawPortrait(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getCurrentString()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
	private bool TestToShrinkFont()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetWidth()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rectangle getBounds()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
