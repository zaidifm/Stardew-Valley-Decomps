using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class CoopMenu : GameMenu
{
	public enum Tab
	{
		HOST_TAB,
		JOIN_TAB
	}

	private string Filter;

	private DialogueBox tutorialDialog;

	private bool wizardSource;

	private static bool showTutorialDialog;

	private Vector2 joinTextSize;

	private Vector2 hostTextSize;

	private bool changingTabs;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CoopMenu(bool tooManyFarms, bool splitScreen = false, Tab initialTab = Tab.JOIN_TAB, string filter = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
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
	public override void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int getTabNumberFromName(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void changeTab(int whichTab, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetTab(Tab new_tab, bool play_sound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
