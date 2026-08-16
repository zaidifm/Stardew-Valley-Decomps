using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.SpecialOrders;

public class SpecialOrderData
{
	public string Name;

	public string Requester;

	public QuestDuration Duration;

	[ContentSerializer(Optional = true)]
	public bool Repeatable;

	[ContentSerializer(Optional = true)]
	public string RequiredTags = "";

	[ContentSerializer(Optional = true)]
	public string Condition = "";

	[ContentSerializer(Optional = true)]
	public string OrderType = "";

	[ContentSerializer(Optional = true)]
	public string SpecialRule = "";

	public string Text;

	[ContentSerializer(Optional = true)]
	public string ItemToRemoveOnEnd;

	[ContentSerializer(Optional = true)]
	public string MailToRemoveOnEnd;

	[ContentSerializer(Optional = true)]
	public List<RandomizedElement> RandomizedElements;

	public List<SpecialOrderObjectiveData> Objectives;

	public List<SpecialOrderRewardData> Rewards;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
