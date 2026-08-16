using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.Locations;

public class IslandSouthEast : IslandLocation
{
	private const string lightId = "IslandSouthEast";

	[XmlIgnore]
	public Texture2D mermaidSprites;

	[XmlIgnore]
	public int lastPlayedNote;

	[XmlIgnore]
	public int songIndex;

	[XmlIgnore]
	public int[] mermaidIdle;

	[XmlIgnore]
	public int[] mermaidWave;

	[XmlIgnore]
	public int[] mermaidReward;

	[XmlIgnore]
	public int[] mermaidDance;

	[XmlIgnore]
	public int mermaidFrameIndex;

	[XmlIgnore]
	public int[] currentMermaidAnimation;

	[XmlIgnore]
	public float mermaidFrameTimer;

	[XmlIgnore]
	public float mermaidDanceTime;

	[XmlIgnore]
	public NetEvent0 mermaidPuzzleSuccess;

	[XmlElement("mermaidPuzzleFinished")]
	public NetBool mermaidPuzzleFinished;

	[XmlIgnore]
	public NetEvent0 fishWalnutEvent;

	[XmlElement("fishedWalnut")]
	public NetBool fishedWalnut;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandSouthEast()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandSouthEast(string map, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnMermaidPuzzleSuccess()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void MakeMapModifications(bool force = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void cleanupBeforePlayerExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetBuriedNutLocations()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool MermaidIsHere()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Item getFish(float millisecondsAfterNibble, string bait, int waterDepth, Farmer who, double baitPotency, Vector2 bobberTile, string locationName = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnFishWalnut()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void TransferDataFromSavedLocation(GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnFlutePlayed(int pitch)
	{
	}
}
