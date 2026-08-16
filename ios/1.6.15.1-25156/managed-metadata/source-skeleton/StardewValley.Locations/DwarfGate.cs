using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Network;

namespace StardewValley.Locations;

public class DwarfGate : INetObject<NetFields>
{
	public NetPoint tilePosition;

	public NetLocationRef locationRef;

	public bool triggeredOpen;

	public NetPointDictionary<bool, NetBool> switches;

	public Dictionary<Point, bool> localSwitches;

	public NetBool opened;

	public bool localOpened;

	public NetInt pressedSwitches;

	public int localPressedSwitches;

	public NetInt gateIndex;

	public NetEvent0 openEvent;

	public NetEvent1Field<Point, NetPoint> pressEvent;

	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DwarfGate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DwarfGate(VolcanoDungeon location, int gate_index, int x, int y, int seed)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnPress(Point point)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenGate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateLocalStates()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateWhenCurrentLocation(GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ApplyTiles()
	{
	}
}
