using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.Buildings;

namespace StardewValley.Menus;

public class PondQueryMenu : IClickableMenu
{
	public const int region_okButton = 101;

	public const int region_emptyButton = 103;

	public const int region_noButton = 105;

	public const int region_nettingButton = 106;

	public new static int width;

	public new static int height;

	public const int unresolved_needs_extra_height = 116;

	protected FishPond _pond;

	protected Object _fishItem;

	protected string _statusText;

	public ClickableTextureComponent emptyButton;

	public ClickableTextureComponent yesButton;

	public ClickableTextureComponent noButton;

	public ClickableTextureComponent changeNettingButton;

	private bool confirmingEmpty;

	protected Rectangle _confirmationBoxRectangle;

	protected string _confirmationText;

	protected float _age;

	private string hoverText;

	public bool yesButtonHeld;

	public bool noButtonHeld;

	public bool changeNettingButtonHeld;

	public bool emptyButtonHeld;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PondQueryMenu(FishPond fish_pond)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void textBoxEnter(TextBox sender)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void finishedPlacingAnimal()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
	public static string getCompletedRequestString(FishPond pond, Object fishItem, Random r)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int measureTotalHeight()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int measureExtraTextHeight(string displayed_text)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string getDisplayedText()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
