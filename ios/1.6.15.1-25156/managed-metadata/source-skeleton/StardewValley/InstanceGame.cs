using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley;

public class InstanceGame
{
	public object staticVarHolder;

	public bool IsMainInstance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public GraphicsDevice GraphicsDevice
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public ContentManager Content
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public GameComponentCollection Components
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public GameWindow Window
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool IsFixedTimeStep
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

	public bool IsActive
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool IsMouseVisible
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

	public TimeSpan TargetElapsedTime
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
	protected virtual void Initialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void LoadContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void UnloadContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Update(GameTime game_time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnActivated(object sender, EventArgs args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Draw(GameTime game_time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void BeginDraw()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void EndDraw()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Exit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InstanceGame()
	{
	}
}
