using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.Menus;

public class ClickableComponent : IScreenReadable
{
	public const int ID_ignore = -500;

	public const int CUSTOM_SNAP_BEHAVIOR = -7777;

	public const int SNAP_AUTOMATIC = -99998;

	public const int SNAP_TO_DEFAULT = -99999;

	public Rectangle bounds;

	public string name;

	public string label;

	public float scale;

	public Item item;

	public bool visible;

	public bool leftNeighborImmutable;

	public bool rightNeighborImmutable;

	public bool upNeighborImmutable;

	public bool downNeighborImmutable;

	public bool fullyImmutable;

	public int myID;

	public int myAlternateID;

	public int leftNeighborID;

	public int rightNeighborID;

	public int upNeighborID;

	public int downNeighborID;

	public int region;

	public bool tryDefaultIfNoRightNeighborExists;

	public bool tryDefaultIfNoDownNeighborExists;

	public string ScreenReaderText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string ScreenReaderDescription
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool ScreenReaderIgnore
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClickableComponent(Rectangle bounds, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClickableComponent(Rectangle bounds, string name, string label)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClickableComponent(Rectangle bounds, Item item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool containsPoint(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool containsPoint(int x, int y, int extraMargin)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void snapMouseCursorToCenter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetUpNeighbors<T>(List<T> components, int id) where T : ClickableComponent
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ChainNeighborsLeftRight<T>(List<T> components) where T : ClickableComponent
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ChainNeighborsUpDown<T>(List<T> components) where T : ClickableComponent
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSnapAutomatic()
	{
	}
}
