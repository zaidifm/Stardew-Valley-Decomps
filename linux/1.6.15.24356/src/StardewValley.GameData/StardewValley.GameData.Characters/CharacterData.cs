using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Characters;

public class CharacterData
{
	public string DisplayName;

	[ContentSerializer(Optional = true)]
	public Season? BirthSeason;

	[ContentSerializer(Optional = true)]
	public int BirthDay;

	[ContentSerializer(Optional = true)]
	public string HomeRegion = "Other";

	[ContentSerializer(Optional = true)]
	public NpcLanguage Language;

	[ContentSerializer(Optional = true)]
	public Gender Gender = Gender.Undefined;

	[ContentSerializer(Optional = true)]
	public NpcAge Age;

	[ContentSerializer(Optional = true)]
	public NpcManner Manner;

	[ContentSerializer(Optional = true)]
	public NpcSocialAnxiety SocialAnxiety = NpcSocialAnxiety.Neutral;

	[ContentSerializer(Optional = true)]
	public NpcOptimism Optimism = NpcOptimism.Neutral;

	[ContentSerializer(Optional = true)]
	public bool IsDarkSkinned;

	[ContentSerializer(Optional = true)]
	public bool CanBeRomanced;

	[ContentSerializer(Optional = true)]
	public string LoveInterest;

	[ContentSerializer(Optional = true)]
	public CalendarBehavior Calendar;

	[ContentSerializer(Optional = true)]
	public SocialTabBehavior SocialTab;

	[ContentSerializer(Optional = true)]
	public string CanSocialize;

	[ContentSerializer(Optional = true)]
	public bool CanReceiveGifts = true;

	[ContentSerializer(Optional = true)]
	public bool CanGreetNearbyCharacters = true;

	[ContentSerializer(Optional = true)]
	public bool? CanCommentOnPurchasedShopItems;

	[ContentSerializer(Optional = true)]
	public string CanVisitIsland;

	[ContentSerializer(Optional = true)]
	public bool? IntroductionsQuest;

	[ContentSerializer(Optional = true)]
	public string ItemDeliveryQuests;

	[ContentSerializer(Optional = true)]
	public bool PerfectionScore = true;

	[ContentSerializer(Optional = true)]
	public EndSlideShowBehavior EndSlideShow = EndSlideShowBehavior.MainGroup;

	[ContentSerializer(Optional = true)]
	public string SpouseAdopts;

	[ContentSerializer(Optional = true)]
	public string SpouseWantsChildren;

	[ContentSerializer(Optional = true)]
	public string SpouseGiftJealousy;

	[ContentSerializer(Optional = true)]
	public int SpouseGiftJealousyFriendshipChange = -30;

	[ContentSerializer(Optional = true)]
	public CharacterSpouseRoomData SpouseRoom;

	[ContentSerializer(Optional = true)]
	public CharacterSpousePatioData SpousePatio;

	[ContentSerializer(Optional = true)]
	public List<string> SpouseFloors = new List<string>();

	[ContentSerializer(Optional = true)]
	public List<string> SpouseWallpapers = new List<string>();

	[ContentSerializer(Optional = true)]
	public int DumpsterDiveFriendshipEffect = -25;

	[ContentSerializer(Optional = true)]
	public int? DumpsterDiveEmote;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> FriendsAndFamily = new Dictionary<string, string>();

	[ContentSerializer(Optional = true)]
	public bool? FlowerDanceCanDance;

	[ContentSerializer(Optional = true)]
	public List<GenericSpawnItemDataWithCondition> WinterStarGifts = new List<GenericSpawnItemDataWithCondition>();

	[ContentSerializer(Optional = true)]
	public string WinterStarParticipant;

	[ContentSerializer(Optional = true)]
	public string UnlockConditions;

	[ContentSerializer(Optional = true)]
	public bool SpawnIfMissing = true;

	[ContentSerializer(Optional = true)]
	public List<CharacterHomeData> Home;

	[ContentSerializer(Optional = true)]
	public string TextureName;

	[ContentSerializer(Optional = true)]
	public List<CharacterAppearanceData> Appearance = new List<CharacterAppearanceData>();

	[ContentSerializer(Optional = true)]
	public Rectangle? MugShotSourceRect;

	[ContentSerializer(Optional = true)]
	public Point Size = new Point(16, 32);

	[ContentSerializer(Optional = true)]
	public bool Breather = true;

	[ContentSerializer(Optional = true)]
	public Rectangle? BreathChestRect;

	[ContentSerializer(Optional = true)]
	public Point? BreathChestPosition;

	[ContentSerializer(Optional = true)]
	public CharacterShadowData Shadow;

	[ContentSerializer(Optional = true)]
	public Point EmoteOffset = Point.Zero;

	[ContentSerializer(Optional = true)]
	public List<int> ShakePortraits = new List<int>();

	[ContentSerializer(Optional = true)]
	public int KissSpriteIndex = 28;

	[ContentSerializer(Optional = true)]
	public bool KissSpriteFacingRight = true;

	[ContentSerializer(Optional = true)]
	public string HiddenProfileEmoteSound;

	[ContentSerializer(Optional = true)]
	public int HiddenProfileEmoteDuration = -1;

	[ContentSerializer(Optional = true)]
	public int HiddenProfileEmoteStartFrame = -1;

	[ContentSerializer(Optional = true)]
	public int HiddenProfileEmoteFrameCount = 1;

	[ContentSerializer(Optional = true)]
	public float HiddenProfileEmoteFrameDuration = 200f;

	[ContentSerializer(Optional = true)]
	public List<string> FormerCharacterNames = new List<string>();

	[ContentSerializer(Optional = true)]
	public int FestivalVanillaActorIndex = -1;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
