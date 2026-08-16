using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.Events;
using StardewValley.Menus;
using xTile.Dimensions;

namespace StardewValley.Mods;

public class ModHooks
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGame1_PerformTenMinuteClockUpdate(Action action)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGame1_NewDayAfterFade(Action action)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGame1_ShowEndOfNightStuff(Action action)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGame1_UpdateControlInput(ref KeyboardState keyboardState, ref MouseState mouseState, ref GamePadState gamePadState, Action action)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGameLocation_ResetForPlayerEntry(GameLocation location, Action action)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnGameLocation_CheckAction(GameLocation location, Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who, Func<bool> action)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual FarmEvent OnUtility_PickFarmEvent(Func<FarmEvent> action)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AfterNewDayBarrier(string barrier_id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatedInitialLocations()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SaveAddedLocations()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnRendering(RenderSteps step, SpriteBatch sb, GameTime time, RenderTarget2D target_screen)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRendered(RenderSteps step, SpriteBatch sb, GameTime time, RenderTarget2D target_screen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool TryDrawMenu(IClickableMenu menu, Action draw_menu_action)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task StartTask(Task task, string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task<T> StartTask<T>(Task<T> task, string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ModHooks()
	{
	}
}
