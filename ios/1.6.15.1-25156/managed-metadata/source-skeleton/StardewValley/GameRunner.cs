using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley;

public class GameRunner : Game
{
	public static GameRunner instance;

	public List<Game1> gameInstances;

	public List<Game1> gameInstancesToRemove;

	public Game1 gamePtr;

	public bool shouldLoadContent;

	protected bool _initialized;

	protected bool _windowSizeChanged;

	public List<int> startButtonState;

	public List<KeyValuePair<Game1, IEnumerator<int>>> activeNewDayProcesses;

	public int nextInstanceId;

	public static int MaxTextureSize;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameRunner()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnActivated(object sender, EventArgs args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SubscribeClientSizeChange()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnWindowSizeChange(object sender, EventArgs args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Draw(GameTime gameTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InnerDraw(GameTime gameTime_)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetNewInstanceID()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Initialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool WasWindowSizeChanged()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMaxSimultaneousPlayers()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitializeMainInstance()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExecuteForInstances(Action<Game1> action)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RemoveGameInstance(Game1 instance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddGameInstance(PlayerIndex player_index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Game1 CreateGameInstance(PlayerIndex player_index = PlayerIndex.One, int index = 0)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void LoadContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void UnloadContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update(GameTime gameTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InvalidateStartPress(PlayerIndex index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsStartDown(PlayerIndex index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void SetInstanceDefaults(InstanceGame instance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SaveInstance(InstanceGame instance, bool force = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LoadInstance(InstanceGame instance, bool force = false)
	{
	}
}
