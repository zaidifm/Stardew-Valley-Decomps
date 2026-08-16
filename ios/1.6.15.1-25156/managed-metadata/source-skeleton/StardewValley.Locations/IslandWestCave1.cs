using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class IslandWestCave1 : IslandLocation
{
	public class CaveCrystal
	{
		public Vector2 tileLocation;

		public int id;

		public int pitch;

		public Color color;

		public Color currentColor;

		public float shakeTimer;

		public float glowTimer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void update()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void activate()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CaveCrystal()
		{
		}
	}

	public const string lightSourceId = "IslandWestCave1";

	[XmlIgnore]
	protected List<CaveCrystal> crystals;

	public const int PHASE_INTRO = 0;

	public const int PHASE_PLAY_SEQUENCE = 1;

	public const int PHASE_WAIT_FOR_PLAYER_INPUT = 2;

	public const int PHASE_NOTHING = 3;

	public const int PHASE_SUCCESSFUL_SEQUENCE = 4;

	public const int PHASE_OUTRO = 5;

	[XmlElement("completed")]
	public NetBool completed;

	[XmlIgnore]
	public NetBool isActivated;

	[XmlIgnore]
	public NetFloat netPhaseTimer;

	[XmlIgnore]
	public float localPhaseTimer;

	[XmlIgnore]
	public float betweenNotesTimer;

	[XmlIgnore]
	public int localPhase;

	[XmlIgnore]
	public NetInt netPhase;

	[XmlIgnore]
	public NetInt currentDifficulty;

	[XmlIgnore]
	public NetInt currentCrystalSequenceIndex;

	[XmlIgnore]
	public int currentPlaybackCrystalSequenceIndex;

	[XmlIgnore]
	public NetInt timesFailed;

	[XmlIgnore]
	public NetList<int, NetInt> currentCrystalSequence;

	[XmlIgnore]
	public NetEvent1Field<int, NetInt> enterValueEvent;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandWestCave1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandWestCave1(string map, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void onActivationChanged(NetBool field, bool old_value, bool new_value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetSharedState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetPuzzle()
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
	public override bool performAction(string[] action, Farmer who, Location tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void updateActivationVisuals()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateActivationTiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void enterValue(int which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void cleanupBeforePlayerExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void TransferDataFromSavedLocation(GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addCompletionTorches()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
