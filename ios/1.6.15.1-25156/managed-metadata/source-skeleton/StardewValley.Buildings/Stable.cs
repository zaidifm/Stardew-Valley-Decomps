using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.Characters;

namespace StardewValley.Buildings;

public class Stable : Building
{
	public Guid HorseId
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
	public Stable()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Stable(Vector2 tileLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Stable(Vector2 tileLocation, Guid horseId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Rectangle? getSourceRectForMenu()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Horse getStableHorse()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point GetDefaultHorseTile()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void grabHorse()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void updateHorseOwnership()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void dayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performActionOnDemolition(GameLocation location)
	{
	}
}
