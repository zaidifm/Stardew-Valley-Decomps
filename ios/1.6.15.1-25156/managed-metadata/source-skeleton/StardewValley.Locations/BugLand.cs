using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace StardewValley.Locations;

public class BugLand : GameLocation
{
	[XmlElement("hasSpawnedBugsToday")]
	public bool hasSpawnedBugsToday;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BugLand()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BugLand(string map, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void TransferDataFromSavedLocation(GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void hostSetup()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitializeBugLand()
	{
	}
}
