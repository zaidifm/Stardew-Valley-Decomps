using System;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.FishPonds;

public class FishPondReward : GenericSpawnItemDataWithCondition
{
	[ContentSerializer(Optional = true)]
	public int RequiredPopulation;

	[ContentSerializer(Optional = true)]
	public float Chance = 1f;

	[ContentSerializer(Optional = true)]
	public int Precedence;

	[Obsolete("Use MinStack instead.")]
	[ContentSerializerIgnore]
	public int? MinQuantity
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

	[Obsolete("Use MaxStack instead.")]
	[ContentSerializerIgnore]
	public int? MaxQuantity
	{
		get
		{
			return null;
		}
		set
		{
			base.MaxStack = value ?? base.MaxStack;
		}
	}
}
