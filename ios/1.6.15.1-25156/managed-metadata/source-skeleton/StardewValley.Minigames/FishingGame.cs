using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.Menus;
using StardewValley.Mobile;

namespace StardewValley.Minigames;

public class FishingGame : IMinigame
{
	internal GameLocation location;

	private LocalizedContentManager content;

	private int timerToStart;

	private int gameEndTimer;

	private int showResultsTimer;

	public bool exit;

	public bool gameDone;

	public int score;

	public int fishCaught;

	public int starTokensWon;

	public int perfections;

	public int perfectionBonus;

	public GameLocation originalLocation;

	public ClickableTextureComponent upperRightCloseButton;

	private bool _leftClickNextUpdate;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FishingGame()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool overrideFreeMouseMovement()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool tick(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void gameDoneAfterFade()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void releaseRightClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveKeyPress(Keys k)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveKeyRelease(Keys k)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EmergencyCancel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void handleCastInput()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void handleCastInputReleased()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReceiveMobileKeyStates(MobileKeyStates mobileKeyStates)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnLeftClick()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnLeftClickRelease(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRightClick()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExitGame()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void startMe()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeScreenSize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void unload()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveEventPoke(int data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string minigameId()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool doMainGameUpdates()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool forceQuit()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetForcedScaleFactor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
