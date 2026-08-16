using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley.BellsAndWhistles;
using StardewValley.Buildings;
using StardewValley.Inventories;
using StardewValley.Minigames;
using StardewValley.Network;
using StardewValley.Network.ChestHit;
using StardewValley.Network.NetEvents;
using StardewValley.SpecialOrders;
using StardewValley.Util;

namespace StardewValley;

public class FarmerTeam : INetObject<NetFields>
{
	public enum RemoteBuildingPermissions
	{
		Off,
		OwnedBuildings,
		On
	}

	public enum SleepAnnounceModes
	{
		All,
		First,
		Off
	}

	public const string GlobalInventoryId_LostItemsShop = "LostItemsShop";

	public const string GlobalInventoryId_JunimoChest = "JunimoChests";

	public readonly NetIntDelta money;

	public readonly NetLongDictionary<NetIntDelta, NetRef<NetIntDelta>> individualMoney;

	public readonly NetIntDelta totalMoneyEarned;

	public readonly NetBool useSeparateWallets;

	public readonly NetBool newLostAndFoundItems;

	public readonly NetBool toggleMineShrineOvernight;

	public readonly NetBool mineShrineActivated;

	public readonly NetBool toggleSkullShrineOvernight;

	public readonly NetBool skullShrineActivated;

	public readonly NetBool farmPerfect;

	public readonly NetList<string, NetString> specialRulesRemovedToday;

	public readonly NetList<string, NetString> itemsToRemoveOvernight;

	public readonly NetList<string, NetString> mailToRemoveOvernight;

	public NetIntDictionary<long, NetLong> cellarAssignments;

	public NetStringHashSet broadcastedMail;

	public readonly NetStringHashSet constructedBuildings;

	public NetStringHashSet collectedNutTracker;

	public NetStringHashSet completedSpecialOrders;

	public NetList<SpecialOrder, NetRef<SpecialOrder>> specialOrders;

	public NetList<SpecialOrder, NetRef<SpecialOrder>> availableSpecialOrders;

	public NetStringHashSet acceptedSpecialOrderTypes;

	public readonly NetCollection<Item> returnedDonations;

	internal readonly ChestHitSynchronizer chestHit;

	public readonly NetStringDictionary<Inventory, NetRef<Inventory>> globalInventories;

	public readonly NetStringDictionary<NetMutex, NetRef<NetMutex>> globalInventoryMutexes;

	public readonly NetFarmerCollection announcedSleepingFarmers;

	public readonly NetEnum<SleepAnnounceModes> sleepAnnounceMode;

	public readonly NetEnum<RemoteBuildingPermissions> farmhandsCanMoveBuildings;

	private readonly NetLongDictionary<Proposal, NetRef<Proposal>> proposals;

	public readonly NetList<MovieInvitation, NetRef<MovieInvitation>> movieInvitations;

	public readonly NetCollection<Item> luauIngredients;

	public readonly NetCollection<Item> grangeDisplay;

	public readonly NetMutex grangeMutex;

	public readonly NetMutex returnedDonationsMutex;

	public readonly NetMutex ordersBoardMutex;

	public readonly NetMutex qiChallengeBoardMutex;

	private readonly NetEvent1Field<Rectangle, NetRectangle> festivalPropRemovalEvent;

	public readonly NetEvent1Field<int, NetInt> addQiGemsToTeam;

	public readonly NetEvent1Field<string, NetString> addCharacterEvent;

	public readonly NetEvent1Field<string, NetString> requestAddCharacterEvent;

	public readonly NetEvent0 requestLeoMove;

	public readonly NetEvent1Field<int, NetInt> kickOutOfMinesEvent;

	public readonly NetEvent1Field<string, NetString> requestNPCGoHome;

	public readonly NetEvent1Field<long, NetLong> requestSpouseSleepEvent;

	public readonly NetEvent1Field<string, NetString> ringPhoneEvent;

	public readonly NetEvent1Field<long, NetLong> requestHorseWarpEvent;

	public readonly NetEvent1Field<long, NetLong> requestPetWarpHomeEvent;

	public readonly NetEvent1Field<long, NetLong> requestMovieEndEvent;

	public readonly NetEvent1Field<long, NetLong> endMovieEvent;

	public readonly NetEventBinary buildingConstructedEvent;

	public readonly NetEventBinary buildingMovedEvent;

	public readonly NetEventBinary buildingDemolishedEvent;

	public readonly NetStringDictionary<int, NetInt> limitedNutDrops;

	private readonly NetEvent1<NutDropRequest> requestNutDrop;

	private readonly NetEvent1<SetSimpleFlagRequest> requestSetSimpleFlag;

	private readonly NetEvent1<SetMailRequest> requestSetMail;

	public readonly NetFarmerPairDictionary<Friendship, NetRef<Friendship>> friendshipData;

	public readonly NetWitnessedLock demolishLock;

	public readonly NetMutex buildLock;

	public readonly NetMutex movieMutex;

	public readonly NetMutex goldenCoconutMutex;

	public readonly SynchronizedShopStock synchronizedShopStock;

	public readonly NetLong theaterBuildDate;

	public readonly NetInt lastDayQueenOfSauceRerunUpdated;

	public readonly NetInt queenOfSauceRerunWeek;

	public readonly NetDouble sharedDailyLuck;

	public readonly NetBool spawnMonstersAtNight;

	public readonly NetBool useLegacyRandom;

	internal readonly NetBool allowChatCheats;

	internal readonly NetBool hasDedicatedHost;

	public readonly NetInt calicoEggSkullCavernRating;

	public readonly NetInt highestCalicoEggRatingToday;

	public readonly NetIntDictionary<int, NetInt> calicoStatueEffects;

	public readonly NetLeaderboards junimoKartScores;

	public PlayerStatusList junimoKartStatus;

	public PlayerStatusList endOfNightStatus;

	public PlayerStatusList festivalScoreStatus;

	public PlayerStatusList sleepStatus;

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
	public FarmerTeam()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCalicoStatueEffect(int effectId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnCalicoStatueEffectAdded(int key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnCalicoEggRatingChanged(NetInt field, int oldValue, int newValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _AddQiGemsToTeam(int amount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnKickOutOfMinesEvent(int mineshaftType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRequestHorseWarp(long uid)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRequestLeoMoveEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MarkCollectedNut(string key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetIndividualMoney(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddIndividualMoney(Farmer who, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetIndividualMoney(Farmer who, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetIntDelta GetMoney(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SpecialOrderActive(string special_order_key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SpecialOrderRuleActive(string special_rule, SpecialOrder order_to_ignore = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddSpecialOrder(string id, int? generationSeed = null, bool forceRepeatable = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpecialOrder GetAvailableSpecialOrder(int index = 0, string type = "")
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckReturnedDonations()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool OnDonatedItemWithdrawn(ISalable salable, Farmer who, int countTaken, ItemStockInformation stock)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool OnReturnedDonationDeposited(ISalable deposited_salable)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRequestMovieEndEvent(long uid)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRequestPetWarpHomeEvent(long uid)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRequestNPCGoHome(string npc_name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRequestSpouseSleepEvent(long uid)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRequestAddCharacterEvent(string character_name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnAddCharacterEvent(string character_name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RequestLimitedNutDrops(string key, GameLocation location, int x, int y, int limit, int rewardAmount = 1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDroppedLimitedNutCount(string key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnRequestNutDrop(NutDropRequest request)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RequestSetSimpleFlag(SimpleFlagType flag, PlayerActionTarget target, string flagId, bool flagState, long? onlyPlayerId = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RequestSetMail(PlayerActionTarget playerTarget, string mailId, MailType mailType, bool add, long? onlyPlayerId = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRingPhoneEvent(string callId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndMovieEvent(long uid)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendBuildingConstructedEvent(GameLocation location, Building building, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBuildingConstructedEvent(BinaryReader reader)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendBuildingMovedEvent(GameLocation location, Building building)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBuildingMovedEvent(BinaryReader reader)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendBuildingDemolishedEvent(GameLocation location, Building building)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBuildingDemolishedEvent(BinaryReader reader)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteFarmhand(Farmer farmhand)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Friendship GetFriendship(long farmer1, long farmer2)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddAnyBroadcastedMail()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsMarried(long farmer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsEngaged(long farmer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public long? GetSpouse(long farmer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FestivalPropsRemoved(Rectangle rect)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendProposal(Farmer receiver, ProposalType proposalType, Item gift = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Proposal GetOutgoingProposal()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveOutgoingProposal()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Proposal GetIncomingProposal()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool locationsMatch(GameLocation location1, GameLocation location2)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double AverageDailyLuck(GameLocation inThisLocation = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double AverageLuckLevel(GameLocation inThisLocation = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double AverageSkillLevel(int skillIndex, GameLocation inThisLocation = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string genderedKey(string baseKey, Farmer farmer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool handleIncomingProposal(Proposal proposal)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool playerIsOnline(long uid)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Inventory GetOrCreateGlobalInventory(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetMutex GetOrCreateGlobalInventoryMutex(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void NewDay()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RequestPlayerAction<T>(T request, NetEvent1<T> @event) where T : BasePlayerActionRequest, new()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRequestPlayerAction(BasePlayerActionRequest request)
	{
	}
}
