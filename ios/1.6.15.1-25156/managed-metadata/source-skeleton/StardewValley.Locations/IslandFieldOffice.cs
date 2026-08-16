using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Network;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class IslandFieldOffice : IslandLocation
{
	public const int totalPieces = 11;

	public const int piece_Skeleton_Back_Leg = 0;

	public const int piece_Skeleton_Ribs = 1;

	public const int piece_Skeleton_Front_Leg = 2;

	public const int piece_Skeleton_Tail = 3;

	public const int piece_Skeleton_Spine = 4;

	public const int piece_Skeleton_Skull = 5;

	public const int piece_Snake_Tail = 6;

	public const int piece_Snake_Spine = 7;

	public const int piece_Snake_Skull = 8;

	public const int piece_Bat = 9;

	public const int piece_Frog = 10;

	[XmlElement("uncollectedRewards")]
	public NetList<Item, NetRef<Item>> uncollectedRewards;

	[XmlIgnore]
	public NetMutex safariGuyMutex;

	private NPC safariGuy;

	[XmlElement("piecesDonated")]
	public NetList<bool, NetBool> piecesDonated;

	[XmlElement("centerSkeletonRestored")]
	public readonly NetBool centerSkeletonRestored;

	[XmlElement("snakeRestored")]
	public readonly NetBool snakeRestored;

	[XmlElement("batRestored")]
	public readonly NetBool batRestored;

	[XmlElement("frogRestored")]
	public readonly NetBool frogRestored;

	[XmlElement("plantsRestoredLeft")]
	public readonly NetBool plantsRestoredLeft;

	[XmlElement("plantsRestoredRight")]
	public readonly NetBool plantsRestoredRight;

	public readonly NetBool hasFailedSurveyToday;

	private bool _shouldTriggerFinalCutscene;

	private float speakerTimer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandFieldOffice()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandFieldOffice(string map, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NPC getSafariGuy()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyPlantRestoreLeft()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyPlantRestoreRight()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyFrogRestore()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyBatRestore()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplySnakeRestore()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplySkeletonRestore()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void TransferDataFromSavedLocation(GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool donatePiece(int which)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isRangeAllTrue(int low, int high)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void triggerFinaleCutscene()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _triggerFinaleCutsceneActual()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _StartFinaleEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnCollectReward(Item item, Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool answerDialogueAction(string questionAndAnswer, string[] questionParams)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToSafariGuy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int getRandomUnfoundBoneIndex()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performAction(string[] action, Farmer who, Location tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
