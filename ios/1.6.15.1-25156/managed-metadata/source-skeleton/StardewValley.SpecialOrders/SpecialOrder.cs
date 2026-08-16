using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;
using Netcode.Validation;
using StardewValley.GameData.SpecialOrders;
using StardewValley.Monsters;
using StardewValley.Network;
using StardewValley.Quests;
using StardewValley.SpecialOrders.Objectives;
using StardewValley.SpecialOrders.Rewards;

namespace StardewValley.SpecialOrders;

[NotImplicitNetField]
[XmlInclude(typeof(OrderReward))]
[XmlInclude(typeof(OrderObjective))]
public class SpecialOrder : INetObject<NetFields>, IQuest
{
	[XmlIgnore]
	public Action<Farmer, Item, int> onItemShipped;

	[XmlIgnore]
	public Action<Farmer, Monster> onMonsterSlain;

	[XmlIgnore]
	public Action<Farmer, Item> onFishCaught;

	[XmlIgnore]
	public Action<Farmer, NPC, Item> onGiftGiven;

	[XmlIgnore]
	public Func<Farmer, NPC, Item, bool, int> onItemDelivered;

	[XmlIgnore]
	public Action<Farmer, Item> onItemCollected;

	[XmlIgnore]
	public Action<Farmer, int> onMineFloorReached;

	[XmlIgnore]
	public Action<Farmer, int> onJKScoreAchieved;

	[XmlIgnore]
	protected bool _objectiveRegistrationDirty;

	[XmlElement("preSelectedItems")]
	public NetStringDictionary<string, NetString> preSelectedItems;

	[XmlElement("selectedRandomElements")]
	public NetStringDictionary<int, NetInt> selectedRandomElements;

	[XmlElement("objectives")]
	public NetList<OrderObjective, NetRef<OrderObjective>> objectives;

	[XmlElement("generationSeed")]
	public NetInt generationSeed;

	[XmlElement("seenParticipantsIDs")]
	public NetLongDictionary<bool, NetBool> seenParticipants;

	[XmlElement("participantsIDs")]
	public NetLongDictionary<bool, NetBool> participants;

	[XmlElement("unclaimedRewardsIDs")]
	public NetLongDictionary<bool, NetBool> unclaimedRewards;

	[XmlElement("donatedItems")]
	public readonly NetCollection<Item> donatedItems;

	[XmlElement("appliedSpecialRules")]
	public bool appliedSpecialRules;

	[XmlIgnore]
	public readonly NetMutex donateMutex;

	[XmlIgnore]
	protected int _isIslandOrder;

	[XmlElement("rewards")]
	public NetList<OrderReward, NetRef<OrderReward>> rewards;

	[XmlIgnore]
	protected int _moneyReward;

	[XmlElement("questKey")]
	public NetString questKey;

	[XmlElement("questName")]
	public NetString questName;

	[XmlElement("questDescription")]
	public NetString questDescription;

	[XmlElement("requester")]
	public NetString requester;

	[XmlElement("orderType")]
	public NetString orderType;

	[XmlElement("specialRule")]
	public NetString specialRule;

	[XmlElement("readyForRemoval")]
	public NetBool readyForRemoval;

	[XmlElement("itemToRemoveOnEnd")]
	public NetString itemToRemoveOnEnd;

	[XmlElement("mailToRemoveOnEnd")]
	public NetString mailToRemoveOnEnd;

	[XmlIgnore]
	protected string _localizedName;

	[XmlIgnore]
	protected string _localizedDescription;

	[XmlElement("dueDate")]
	public NetInt dueDate;

	[XmlElement("duration")]
	public NetEnum<QuestDuration> questDuration;

	[XmlIgnore]
	protected List<OrderObjective> _registeredObjectives;

	[XmlIgnore]
	protected Dictionary<Item, bool> _highlightLookup;

	[XmlIgnore]
	protected SpecialOrderData _orderData;

	[XmlElement("questState")]
	public NetEnum<SpecialOrderStatus> questState;

	[XmlIgnore]
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
	public SpecialOrder()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetDuration(QuestDuration duration)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnFail()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetCompleteObjectivesCount()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ConfirmCompleteDonations()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateDonationCounts()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HighlightAcceptableItems(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetAcceptCount(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckTags(string tag_list)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckTag(string tag)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsIslandOrder()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsSpecialOrdersBoardUnlocked()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveAllSpecialOrders(string orderType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateAvailableSpecialOrders(string orderType, bool forceRefresh)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CanStartOrderNow(string orderId, SpecialOrderData order)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SpecialOrder GetSpecialOrder(string key, int? generation_seed)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string MakeLocalizationReplacements(string data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string Parse(string data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual SpecialOrderData GetData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetData(string id, out SpecialOrderData data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitializeNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _UpdateObjectiveRegistration()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UsesDropBox(string box_id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMinimumDropBoxCapacity(string box_id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RemoveFromParticipants()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MarkForRemovalIfEmpty()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void HostHandleQuestEnd()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _AddSpecialRulesIfNecessary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _RemoveSpecialRuleIfNecessary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddSpecialRule(string rule)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveSpecialRuleAtEndOfDay(string rule)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RemoveSpecialRule(string rule)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool HasMoneyReward()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Fail()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddObjective(OrderObjective objective)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckCompletion()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDescription()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetObjectiveDescriptions()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanBeCancelled()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MarkAsViewed()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsHidden()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShouldDisplayAsNew()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasReward()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMoneyReward()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShouldDisplayAsComplete()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTimedQuest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDaysLeft()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnMoneyRewardClaimed()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool OnLeaveQuestPage()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
