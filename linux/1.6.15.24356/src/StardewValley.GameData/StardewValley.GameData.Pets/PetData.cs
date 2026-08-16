using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Pets;

public class PetData
{
	public string DisplayName;

	public string BarkSound;

	public string ContentSound;

	[ContentSerializer(Optional = true)]
	public int RepeatContentSoundAfter = -1;

	[ContentSerializer(Optional = true)]
	public Point EmoteOffset;

	[ContentSerializer(Optional = true)]
	public Point EventOffset;

	[ContentSerializer(Optional = true)]
	public string AdoptionEventLocation = "Farm";

	[ContentSerializer(Optional = true)]
	public string AdoptionEventId;

	public PetSummitPerfectionEventData SummitPerfectionEvent;

	[ContentSerializer(Optional = true)]
	public int MoveSpeed = 2;

	[ContentSerializer(Optional = true)]
	public float SleepOnBedChance = 0.05f;

	[ContentSerializer(Optional = true)]
	public float SleepNearBedChance = 0.3f;

	[ContentSerializer(Optional = true)]
	public float SleepOnRugChance = 0.5f;

	public List<PetBehavior> Behaviors;

	[ContentSerializer(Optional = true)]
	public float GiftChance = 0.2f;

	[ContentSerializer(Optional = true)]
	public List<PetGift> Gifts = new List<PetGift>();

	public List<PetBreed> Breeds;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;

	public PetBreed GetBreedById(string breedId, bool allowNull = false)
	{
		foreach (PetBreed breed in Breeds)
		{
			if (breed.Id == breedId)
			{
				return breed;
			}
		}
		if (!allowNull)
		{
			return Breeds[0];
		}
		return null;
	}
}
