using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.FarmAnimals;

public class FarmAnimalData
{
	[ContentSerializer(Optional = true)]
	public string DisplayName;

	[ContentSerializer(Optional = true)]
	public string House;

	[ContentSerializer(Optional = true)]
	public FarmAnimalGender Gender;

	[ContentSerializer(Optional = true)]
	public int PurchasePrice = -1;

	[ContentSerializer(Optional = true)]
	public int SellPrice;

	[ContentSerializer(Optional = true)]
	public string ShopTexture;

	[ContentSerializer(Optional = true)]
	public Rectangle ShopSourceRect;

	[ContentSerializer(Optional = true)]
	public string ShopDisplayName;

	[ContentSerializer(Optional = true)]
	public string ShopDescription;

	[ContentSerializer(Optional = true)]
	public string ShopMissingBuildingDescription;

	[ContentSerializer(Optional = true)]
	public string RequiredBuilding;

	[ContentSerializer(Optional = true)]
	public string UnlockCondition;

	[ContentSerializer(Optional = true)]
	public List<AlternatePurchaseAnimals> AlternatePurchaseTypes;

	[ContentSerializer(Optional = true)]
	public List<string> EggItemIds;

	[ContentSerializer(Optional = true)]
	public int IncubationTime = -1;

	[ContentSerializer(Optional = true)]
	public int IncubatorParentSheetOffset = 1;

	[ContentSerializer(Optional = true)]
	public string BirthText;

	[ContentSerializer(Optional = true)]
	public int DaysToMature = 1;

	[ContentSerializer(Optional = true)]
	public bool CanGetPregnant;

	[ContentSerializer(Optional = true)]
	public int DaysToProduce = 1;

	[ContentSerializer(Optional = true)]
	public FarmAnimalHarvestType HarvestType;

	[ContentSerializer(Optional = true)]
	public string HarvestTool;

	[ContentSerializer(Optional = true)]
	public List<FarmAnimalProduce> ProduceItemIds = new List<FarmAnimalProduce>();

	[ContentSerializer(Optional = true)]
	public List<FarmAnimalProduce> DeluxeProduceItemIds = new List<FarmAnimalProduce>();

	[ContentSerializer(Optional = true)]
	public bool ProduceOnMature;

	[ContentSerializer(Optional = true)]
	public int FriendshipForFasterProduce = -1;

	[ContentSerializer(Optional = true)]
	public int DeluxeProduceMinimumFriendship = 200;

	[ContentSerializer(Optional = true)]
	public float DeluxeProduceCareDivisor = 1200f;

	[ContentSerializer(Optional = true)]
	public float DeluxeProduceLuckMultiplier;

	[ContentSerializer(Optional = true)]
	public bool CanEatGoldenCrackers = true;

	[ContentSerializer(Optional = true)]
	public int ProfessionForHappinessBoost = -1;

	[ContentSerializer(Optional = true)]
	public int ProfessionForQualityBoost = -1;

	[ContentSerializer(Optional = true)]
	public int ProfessionForFasterProduce = -1;

	[ContentSerializer(Optional = true)]
	public string Sound;

	[ContentSerializer(Optional = true)]
	public string BabySound;

	public string Texture;

	[ContentSerializer(Optional = true)]
	public string HarvestedTexture;

	[ContentSerializer(Optional = true)]
	public string BabyTexture;

	[ContentSerializer(Optional = true)]
	public bool UseFlippedRightForLeft;

	[ContentSerializer(Optional = true)]
	public int SpriteWidth = 16;

	[ContentSerializer(Optional = true)]
	public int SpriteHeight = 16;

	[ContentSerializer(Optional = true)]
	public bool UseDoubleUniqueAnimationFrames;

	[ContentSerializer(Optional = true)]
	public int SleepFrame = 12;

	[ContentSerializer(Optional = true)]
	public Point EmoteOffset = Point.Zero;

	[ContentSerializer(Optional = true)]
	public Point SwimOffset = new Point(0, 112);

	[ContentSerializer(Optional = true)]
	public List<FarmAnimalSkin> Skins;

	[ContentSerializer(Optional = true)]
	public FarmAnimalShadowData ShadowWhenBabySwims;

	[ContentSerializer(Optional = true)]
	public FarmAnimalShadowData ShadowWhenBaby;

	[ContentSerializer(Optional = true)]
	public FarmAnimalShadowData ShadowWhenAdultSwims;

	[ContentSerializer(Optional = true)]
	public FarmAnimalShadowData ShadowWhenAdult;

	[ContentSerializer(Optional = true)]
	public FarmAnimalShadowData Shadow;

	[ContentSerializer(Optional = true)]
	public bool CanSwim;

	[ContentSerializer(Optional = true)]
	public bool BabiesFollowAdults;

	[ContentSerializer(Optional = true)]
	public int GrassEatAmount = 2;

	[ContentSerializer(Optional = true)]
	public int HappinessDrain;

	[ContentSerializer(Optional = true)]
	public Vector2 UpDownPetHitboxTileSize = new Vector2(1f, 1f);

	[ContentSerializer(Optional = true)]
	public Vector2 LeftRightPetHitboxTileSize = new Vector2(1f, 1f);

	[ContentSerializer(Optional = true)]
	public Vector2 BabyUpDownPetHitboxTileSize = new Vector2(1f, 1f);

	[ContentSerializer(Optional = true)]
	public Vector2 BabyLeftRightPetHitboxTileSize = new Vector2(1f, 1f);

	[ContentSerializer(Optional = true)]
	public List<StatIncrement> StatToIncrementOnProduce;

	[ContentSerializer(Optional = true)]
	public bool ShowInSummitCredits;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;

	public FarmAnimalShadowData GetShadow(bool isBaby, bool isSwimming)
	{
		if (isBaby)
		{
			object obj;
			if (!isSwimming)
			{
				obj = ShadowWhenBaby;
				if (obj == null)
				{
					return Shadow;
				}
			}
			else
			{
				obj = ShadowWhenBabySwims ?? ShadowWhenBaby ?? Shadow;
			}
			return (FarmAnimalShadowData)obj;
		}
		object obj2;
		if (!isSwimming)
		{
			obj2 = ShadowWhenAdult;
			if (obj2 == null)
			{
				return Shadow;
			}
		}
		else
		{
			obj2 = ShadowWhenAdultSwims ?? ShadowWhenAdult ?? Shadow;
		}
		return (FarmAnimalShadowData)obj2;
	}
}
