using System.Runtime.CompilerServices;

namespace StardewValley;

public class LocationRequest
{
	public delegate void Callback();

	public string Name;

	public bool IsStructure;

	public GameLocation Location;

	public bool DoFade;

	[CompilerGenerated]
	private Callback m_OnLoad;

	[CompilerGenerated]
	private Callback m_OnWarp;

	public event Callback OnLoad
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Callback OnWarp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LocationRequest(string name, bool isStructure, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Loaded(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Warped(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsRequestFor(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
