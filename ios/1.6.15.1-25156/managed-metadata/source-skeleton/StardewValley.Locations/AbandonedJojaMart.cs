using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley.Network;

namespace StardewValley.Locations;

public class AbandonedJojaMart : GameLocation
{
	[XmlIgnore]
	private readonly NetEvent0 restoreAreaCutsceneEvent;

	[XmlIgnore]
	public NetMutex bundleMutex;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AbandonedJojaMart()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AbandonedJojaMart(string mapPath, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkBundle()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateEvenIfFarmerIsntHere(GameTime time, bool ignoreWasUpdatedFlush = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void restoreAreaCutscene()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doRestoreAreaCutscene()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetSharedState()
	{
	}
}
