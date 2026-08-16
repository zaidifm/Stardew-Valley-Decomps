using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace StardewValley;

public class KeyboardDispatcher
{
	protected string _enteredText;

	protected List<char> _commandInputs;

	protected List<Keys> _keysDown;

	protected List<char> _charsEntered;

	protected GameWindow _window;

	private IKeyboardSubscriber _subscriber;

	private string _pasteResult;

	public IKeyboardSubscriber Subscriber
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Cleanup()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KeyboardDispatcher(GameWindow window)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShouldSuppress()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Discard()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Poll()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[STAThread]
	private void PasteThread()
	{
	}
}
