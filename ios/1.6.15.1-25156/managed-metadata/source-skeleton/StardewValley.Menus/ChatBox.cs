using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.Logging;

namespace StardewValley.Menus;

public class ChatBox : IClickableMenu
{
	public const int chatMessage = 0;

	public const int errorMessage = 1;

	public const int userNotificationMessage = 2;

	public const int privateMessage = 3;

	public const int defaultMaxMessages = 10;

	public const int timeToDisplayMessages = 600;

	public const int chatboxWidth = 896;

	public const int chatboxHeight = 56;

	public const int region_chatBox = 101;

	public const int region_emojiButton = 102;

	public ChatTextBox chatBox;

	public ClickableComponent chatBoxCC;

	private readonly IGameLogger CheatCommandChatLogger;

	public List<ChatMessage> messages;

	private KeyboardState oldKBState;

	private List<string> cheatHistory;

	private int cheatHistoryPosition;

	public int maxMessages;

	public static Texture2D emojiTexture;

	public ClickableTextureComponent emojiMenuIcon;

	public EmojiMenu emojiMenu;

	public bool choosingEmoji;

	private long lastReceivedPrivateMessagePlayerId;

	private bool _justShownKeyboard;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChatBox()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updatePosition()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void textBoxEnter(string text_to_send)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void textBoxEnter(TextBox sender)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void addInfoMessage(string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void globalInfoMessage(string messageKey, params string[] args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void addErrorMessage(string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void listPlayers(bool otherPlayersOnly = false, bool onlineOnly = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void runCommand(string commandText)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void cheat(string command, bool isDebug = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void replyPrivateMessage(string[] command)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Farmer findMatchingFarmer(string[] command, ref int matchingIndex, bool allowMatchingByUserName = false, bool onlineOnly = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void sendPrivateMessage(string[] command)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isActive()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void activate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void clickAway()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isWithinBounds(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void setText(string text)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons button)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isHoveringOverClickable(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string formattedUserName(Farmer farmer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string formattedUserNameLong(Farmer farmer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string formatMessage(long sourceFarmer, int chatKind, string message)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Color messageColor(int chatKind)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void receiveChatMessage(long sourceFarmer, int chatKind, LocalizedContentManager.LanguageCode language, string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void addMessage(string message, Color color)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addNiceTryEasterEggMessage()
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
	public override void receiveScrollWheelAction(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SpriteFont messageFont(LocalizedContentManager.LanguageCode language)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getOldMessagesBoxHeight()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
