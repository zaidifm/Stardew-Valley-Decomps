using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.BellsAndWhistles;
using StardewValley.Network;
using StardewValley.Objects;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class DesertFestival : Desert
{
	public enum RaceState
	{
		PreRace,
		StartingLine,
		Ready,
		Set,
		Go,
		AnnounceWinner,
		AnnounceWinner2,
		AnnounceWinner3,
		AnnounceWinner4,
		RaceEnd,
		RacesOver
	}

	public const int CALICO_STATUE_GHOST_INVASION = 0;

	public const int CALICO_STATUE_SERPENT_INVASION = 1;

	public const int CALICO_STATUE_SKELETON_INVASION = 2;

	public const int CALICO_STATUE_BAT_INVASION = 3;

	public const int CALICO_STATUE_ASSASSIN_BUGS = 4;

	public const int CALICO_STATUE_THIN_SHELLS = 5;

	public const int CALICO_STATUE_MEAGER_MEALS = 6;

	public const int CALICO_STATUE_MONSTER_SURGE = 7;

	public const int CALICO_STATUE_SHARP_TEETH = 8;

	public const int CALICO_STATUE_MUMMY_CURSE = 9;

	public const int CALICO_STATUE_SPEED_BOOST = 10;

	public const int CALICO_STATUE_REFRESH = 11;

	public const int CALICO_STATUE_50_EGG_TREASURE = 12;

	public const int CALICO_STATUE_NO_EFFECT = 13;

	public const int CALICO_STATUE_TOOTH_FILE = 14;

	public const int CALICO_STATUE_25_EGG_TREASURE = 15;

	public const int CALICO_STATUE_10_EGG_TREASURE = 16;

	public const int CALICO_STATUE_100_EGG_TREASURE = 17;

	public static readonly int[] CalicoStatueInvasionIds;

	public const int NUM_SCHOLAR_QUESTIONS = 4;

	public const string FISHING_QUEST_ID = "98765";

	protected RandomizedPlantFurniture _cactusGuyRevealItem;

	protected float _cactusGuyRevealTimer;

	protected float _cactusShakeTimer;

	protected int _currentlyShownCactusID;

	protected NetEvent1Field<int, NetInt> _revealCactusEvent;

	protected NetEvent1Field<int, NetInt> _hideCactusEvent;

	protected MoneyDial eggMoneyDial;

	[XmlIgnore]
	public NetList<Racer, NetRef<Racer>> netRacers;

	[XmlIgnore]
	protected List<Racer> _localRacers;

	[XmlIgnore]
	protected float festivalChimneyTimer;

	[XmlIgnore]
	public List<int> finishedRacers;

	[XmlIgnore]
	public int racerCount;

	[XmlIgnore]
	public int totalRacers;

	[XmlIgnore]
	public NetEvent1Field<string, NetString> announceRaceEvent;

	[XmlIgnore]
	public NetEnum<RaceState> currentRaceState;

	[XmlIgnore]
	public NetLongDictionary<int, NetInt> sabotages;

	[XmlIgnore]
	public NetLongDictionary<int, NetInt> raceGuesses;

	[XmlIgnore]
	public NetLongDictionary<int, NetInt> nextRaceGuesses;

	[XmlIgnore]
	public NetLongDictionary<bool, NetBool> specialRewardsCollected;

	[XmlIgnore]
	public NetLongDictionary<int, NetInt> rewardsToCollect;

	[XmlIgnore]
	public NetInt lastRaceWinner;

	[XmlIgnore]
	protected float _raceStateTimer;

	protected string _raceText;

	protected float _raceTextTimer;

	protected bool _raceTextShake;

	protected int _localSabotageText;

	protected int _currentScholarQuestion;

	protected int _cookIngredient;

	protected int _cookSauce;

	public Vector3[][] raceTrack;

	private bool checkedMineExplanation;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DesertFestival()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DesertFestival(string mapPath, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetupMerchantSchedule(NPC character, int shop_index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCamel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ShowCamelAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void checkForMusic(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetFestivalMusic()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string GetLocationSpecificMusic()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void digUpArtifactSpot(int xLocation, int yLocation, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CollectRacePrizes()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performTouchAction(string full_action_string, Vector2 player_standing_position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetMakeoverEvent()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReceiveMakeOver()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ReceiveMakeOver(int randomSeedOverride = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AfterMakeOver()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NPC GetStylist()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void addCalicoStatueSpeedBuff()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performAction(string action, Farmer who, Location tile_location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetCactusMail()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetScholarMail()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Response[] GetRacerResponses()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ShowSabotagedRaceText()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void generateNextScholarQuestion()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void customQuestCompleteBehavior(string questId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool answerDialogueAction(string question_and_answer, string[] question_params)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CactusGuyHideCactus(int seed)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CactusGuyRevealCactus(int seed)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanMakeAnotherRaceGuess()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRaceWon(int winner)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddSmokePuff(Vector2 v)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CleanupFestival()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawOverlays(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAlwaysFrontLayer(SpriteBatch sb)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetTrackPosition(int track_index, float horizontal_position)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performTenMinuteUpdate(int timeOfDay)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AnnounceRace(string text)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void cleanupBeforePlayerExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetupFestivalDay()
	{
	}
}
