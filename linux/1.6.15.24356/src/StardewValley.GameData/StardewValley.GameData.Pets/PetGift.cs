using System;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Pets;

public class PetGift : GenericSpawnItemDataWithCondition
{
	[ContentSerializer(Optional = true)]
	public int MinimumFriendshipThreshold { get; set; } = 1000;

	[ContentSerializer(Optional = true)]
	public float Weight { get; set; } = 1f;

	[Obsolete("Use ItemId instead.")]
	[ContentSerializerIgnore]
	public string QualifiedItemID
	{
		get
		{
			return null;
		}
		set
		{
			base.ItemId = value ?? base.ItemId;
		}
	}

	[Obsolete("Use MinStack instead.")]
	[ContentSerializerIgnore]
	public int? Stack
	{
		get
		{
			return null;
		}
		set
		{
			base.MinStack = value ?? base.MinStack;
		}
	}
}
