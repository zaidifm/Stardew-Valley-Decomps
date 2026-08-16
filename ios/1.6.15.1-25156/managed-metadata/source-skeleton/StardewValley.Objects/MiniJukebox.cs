using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.Objects;

public class MiniJukebox : Object
{
	private bool showNote;

	public override string TypeDefinitionId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MiniJukebox()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MiniJukebox(Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterToLocation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performRemoveAction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSongChosen(string selection)
	{
	}
}
