using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.BellsAndWhistles;

namespace StardewValley.Menus;

public class SaveGameMenu : IClickableMenu, IDisposable
{
	private IEnumerator<int> loader;

	private int completePause;

	public bool quit;

	public bool hasDrawn;

	private SparklingText saveText;

	private int margin;

	private StringBuilder _stringBuilder;

	private float _ellipsisDelay;

	private int _ellipsisCount;

	protected bool _hasSentFarmhandData;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SaveGameMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void complete()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void saveClientOptions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
	}
}
