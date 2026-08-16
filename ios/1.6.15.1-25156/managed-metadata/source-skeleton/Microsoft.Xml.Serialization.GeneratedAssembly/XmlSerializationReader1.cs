using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using ContentManifest;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Netcode;
using Netcode.Validation;
using StardewValley;
using StardewValley.Audio;
using StardewValley.BellsAndWhistles;
using StardewValley.Buffs;
using StardewValley.Buildings;
using StardewValley.Characters;
using StardewValley.Constants;
using StardewValley.Enchantments;
using StardewValley.Locations;
using StardewValley.Menus;
using StardewValley.Minigames;
using StardewValley.Monsters;
using StardewValley.Network;
using StardewValley.Network.ChestHit;
using StardewValley.Network.Dedicated;
using StardewValley.Network.NetReady;
using StardewValley.Objects;
using StardewValley.Objects.Trinkets;
using StardewValley.Pathfinding;
using StardewValley.Projectiles;
using StardewValley.Quests;
using StardewValley.SaveMigrations;
using StardewValley.SaveSerialization;
using StardewValley.SpecialOrders;
using StardewValley.SpecialOrders.Objectives;
using StardewValley.SpecialOrders.Rewards;
using StardewValley.TerrainFeatures;
using StardewValley.Tests;
using StardewValley.TokenizableStrings;
using StardewValley.Tools;
using StardewValley.Util;
using StardewValley.WorldMaps;
using TinyTween;

namespace Microsoft.Xml.Serialization.GeneratedAssembly;

public class XmlSerializationReader1 : XmlSerializationReader
{
	private Hashtable _CollisionMaskValues;

	private string id705_notesFound;

	private string id83_AxeEnchantment;

	private string id380_ResourceClump;

	private string id617_indexOfMenuItemView;

	private string id1453_itemIndex;

	private string id1140_Keys;

	private string id300_Phone;

	private string id245_Item;

	private string id48_Barn;

	private string id413_MapAreaPositionWithContext;

	private string id547_rotations;

	private string id1279_lungeDecelerationTicks;

	private string id645_IsBottomless;

	private string id1518_rainbowLights;

	private string id655_fertilized;

	private string id1594_FishingLevel;

	private string id520_separateWalletItems;

	private string id1652_displayMode;

	private string id454_specialItem;

	private string id470_price;

	private string id1499_greenhouseMoved;

	private string id1207_ignoreOutdoorLighting;

	private string id649_treeType;

	private string id99_HaymakerEnchantment;

	private string id1288_projectileOutroTimer;

	private string id30_ArrayOfString;

	private string id1125_ArrayOfSpecialOrder;

	private string id1389_animalDoorOpen;

	private string id62_Cat;

	private string id1240_endOfRouteBehaviorName;

	private string id52_GreenhouseBuilding;

	private string id1098_ArrayOfString1;

	private string id143_Item;

	private string id954_pantsColor;

	private string id806_inventorySlot6;

	private string id1752_bounceSound;

	private string id837_sizeButtonB;

	private string id1566_grantedMails;

	private string id342_Vector2Serializer;

	private string id1395_Color1Default;

	private string id1477_mermaidPuzzleFinished;

	private string id1411_sign;

	private string id1448_visited;

	private string id1219_birthday_Day;

	private string id1676_farmhandsCanMoveBuildings;

	private string id944_mostRecentBed;

	private string id1743_WeatherForTomorrow;

	private string id933_hasMagnifyingGlass;

	private string id387_Tool;

	private string id1203_isFarm;

	private string id804_inventorySlot4;

	private string id1213_furniture;

	private string id841_hardwareCursor;

	private string id676_stat_dictionary;

	private string id188_MineInfo;

	private string id1595_MiningLevel;

	private string id173_IslandLocation;

	private string id1529_isQuarryArea;

	private string id1744_Weather;

	private string id1099_Item;

	private string id658_whichView;

	private string id1141_LightContext;

	private string id442_Size;

	private string id1760_travelDistance;

	private string id1050_destroy;

	private string id319_CraftingQuest;

	private string id96_FishingRodEnchantment;

	private string id672_tile;

	private string id1696_glowTimer;

	private string id191_MovieTheater;

	private string id182_CaveCrystal;

	private string id1112_ArrayOfResourceClump;

	private string id1341_burstTime;

	private string id1664_broadcastedMail;

	private string id1047_dailyQuest;

	private string id781_zoomLevel;

	private string id808_inventorySlot8;

	private string id246_Item;

	private string id811_inventorySlot11;

	private string id628_IsEfficient;

	private string id832_lastSeenBuildNumber;

	private string id1008_lastSleepPoint;

	private string id1069_xmlKey;

	private string id1067_dialogueparts;

	private string id1577_dropBox;

	private string id862_ignoreMovementAnimation;

	private string id809_inventorySlot9;

	private string id987_gender;

	private string id1625_total;

	private string id1017_totalMoneyEarned;

	private string id812_inventorySlot12;

	private string id370_Stats;

	private string id494_immunityBonus;

	private string id948_shoes;

	private string id934_hasRustyKey;

	private string id1764_ignoreLocationCollision;

	private string id252_DedicatedServer;

	private string id287_CombinedRing;

	private string id961_changeWalletTypeTonight;

	private string id1572_maxCount;

	private string id1792_parrotPlatformsUnlocked;

	private string id629_AnimationSpeedModifier;

	private string id1490_drivingOff;

	private string id1325_leapProgress;

	private string id747_playFootstepSounds;

	private string id1276_lungeFrequency;

	private string id758_screenFlash;

	private string id690_geodesCracked;

	private string id1304_velocity;

	private string id1077_WaterTileData;

	private string id443_flipFarmer;

	private string id757_invertScrollDirection;

	private string id1519_isLightingDark;

	private string id1076_TweenOfColor;

	private string id184_LibraryMuseum;

	private string id790_useToolButton;

	private string id176_IslandShrine;

	private string id31_string;

	private string id1497_hasSeenGrandpaNote;

	private string id404_Torch;

	private string id512_enchantments;

	private string id419_TweenState;

	private string id1602_AttackMultiplier;

	private string id1281_lungeTimer;

	private string id774_useLegacySlingshotFiring;

	private string id259_NetDancePartner;

	private string id129_RemoteBuildingPermissions;

	private string id884_wasAutoPet;

	private string id1693_pitch;

	private string id936_hasSpecialCharm;

	private string id879_daysOwned;

	private string id16_ArrayOfDouble;

	private string id1052_questType;

	private string id321_FishingQuest;

	private string id1660_specialRulesRemovedToday;

	private string id57_ShippingBin;

	private string id1666_collectedNutTracker;

	private string id1520_calicoEggIconTimerShake;

	private string id484_scale;

	private string id1615_itemFound;

	private string id656_stopGrowingMoss;

	private string id1007_lastSleepLocation;

	private string id881_daysSinceLastLay;

	private string id1759_maxTravelDistance;

	private string id844_buttonBSize;

	private string id26_ArrayOfPoint;

	private string id1331_segments;

	private string id1230_daysUntilNotInvisible;

	private string id549_defaultSourceRect;

	private string id1630_moving;

	private string id1700_currentTrackIndex;

	private string id144_LocalMultiplayer;

	private string id869_Speed;

	private string id615_initialParentTileIndex;

	private string id1332_segmentCount;

	private string id667_numberOfWeeds;

	private string id355_ReachMineFloorObjective;

	private string id369_StartupPreferences;

	private string id1480_sandDuggy;

	private string id1424_shouldSendOutJunimos;

	private string id608_Item;

	private string id1747_IsLightning;

	private string id1184_platformContainersLeft;

	private string id518_lidFrameCount;

	private string id1012_movementMultiplier;

	private string id1385_hayCapacity;

	private string id1629_ExtrapolationEnabled;

	private string id1043__questTitle;

	private string id202_Woods;

	private string id698_ironFound;

	private string id1838_activatedGoldenParrot;

	private string id1192_isUpgrade;

	private string id1372_skinId;

	private string id958_shirtItem;

	private string id766_windowedBorderlessFullscreen;

	private string id883_fullness;

	private string id576_currentPhase;

	private string id678_beveragesMade;

	private string id638_knockback;

	private string id557_generationSeed;

	private string id1162_Item;

	private string id172_IslandHut;

	private string id1303_startPosition;

	private string id1534_witchStatueGone;

	private string id1516_calicoStatueSpot;

	private string id795_menuButton;

	private string id1670_acceptedSpecialOrderTypes;

	private string id1686_calicoEggSkullCavernRating;

	private string id923_horseName;

	private string id1006_homeLocation;

	private string id1298_nextWanderTime;

	private string id899_dialogueQuestionsAnswered;

	private string id1271_lightSourceId;

	private string id1191_buildingTile;

	private string id1062_numberToFish;

	private string id1088_SaveablePairOfInt64Options;

	private string id610_sourceTexture;

	private string id101_JadeEnchantment;

	private string id69_Raccoon;

	private string id186_MermaidHouse;

	private string id1415_neededItemCount;

	private string id1817_bundleData;

	private string id465_isSpawnedObject;

	private string id14_ArrayOfColor;

	private string id1451_locationGemBird;

	private string id1224_isInvisible;

	private string id255_LocationWeather;

	private string id1113_ArrayOfLargeTerrainFeature;

	private string id1552_questName;

	private string id112_ShavingEnchantment;

	private string id498_indexInTileSheetFemale;

	private string id417_QuaternionTween;

	private string id458_modData;

	private string id260_ArrayOfFarmer;

	private string id1265_hasSpecialItem;

	private string id235_ShadowShaman;

	private string id831_dateTimeScale;

	private string id1753_piercesLeft;

	private string id605_displayNameOverrideTemplate;

	private string id1694_currentColor;

	private string id1589_InterpolationTicks;

	private string id568_drawShadow;

	private string id759_showPlacementTileForGamepad;

	private string id564_datePlanted;

	private string id648_growthStage;

	private string id789_cancelButton;

	private string id102_LightweightEnchantment;

	private string id689_fishCaught;

	private string id659_treeId;

	private string id1502_itemsToStartSellingTomorrow;

	private string id1100_Item;

	private string id949_accessory;

	private string id43_SandDuggyState;

	private string id340_LegacyDescriptionElement;

	private string id258_NetCharacterRef;

	private string id908_achievements;

	private string id66_Junimo;

	private string id1034_died;

	private string id833_showCameraButton;

	private string id591_successColor;

	private string id1485_whacked;

	private string id1509_isFogUp;

	private string id1766_ignoreMeleeAttacks;

	private string id1441_floor;

	private string id1148_Item;

	private string id665_growthRate;

	private string id1220_manners;

	private string id1557_readyForRemoval;

	private string id1793_foundBuriedNuts;

	private string id1135_Item;

	private string id199_Summit;

	private string id468_isOn;

	private string id1250_endOfRouteBehavior;

	private string id1708_moveSpeed;

	private string id998_seasonForSaveGame;

	private string id1132_Item;

	private string id752_mouseControls;

	private string id661_fruitsOnTree;

	private string id282_Chest;

	private string id396_MilkPail;

	private string id666_grassType;

	private string id517_currentLidFrame;

	private string id1478_fishedWalnut;

	private string id633_maxDamage;

	private string id533_globalInventoryId;

	private string id1151_Item;

	private string id162_RaceState;

	private string id956_leftRing;

	private string id1196_characters;

	private string id673_id;

	private string id1657_toggleSkullShrineOvernight;

	private string id304_SpecialItem;

	private string id1437_TicketPrice;

	private string id405_BoundingBoxGroup;

	private string id1118_ArrayOfArrayOfVector3;

	private string id1057_questTitle;

	private string id302_Ring;

	private string id40_SoundContext;

	private string id1482_farmhouseMailbox;

	private string id194_Railroad;

	private string id1801_uniqueIDForThisGame;

	private string id272_NonInstancedStatic;

	private string id423_WalkDirection;

	private string id1526_isSlimeArea;

	private string id292_Furniture;

	private string id1527_isDinoArea;

	private string id567_inPot;

	private string id587_forageCrop;

	private string id1089_SaveablePairOfStringInt32;

	private string id307_TV;

	private string id713_sheepWoolProduced;

	private string id1711_tripTimer;

	private string id379_LargeTerrainFeature;

	private string id989_mineralsFound;

	private string id326_LostItemQuest;

	private string id792_moveRightButton;

	private string id896_professions;

	private string id620_animationSpeedModifier;

	private string id1613_npcName;

	private string id937_HasTownKey;

	private string id166_Forest;

	private string id1318_ageUntilFullGrown;

	private string id263_NetMutex;

	private string id504_B;

	private string id1349_isMage;

	private string id440_Height;

	private string id1126_Item;

	private string id771_enableServer;

	private string id481_lastInputItem;

	private string id1765_ignoreObjectCollisions;

	private string id198_Submarine;

	private string id294_HairDrawType;

	private string id1623_numberKilled;

	private string id1679_grangeDisplay;

	private string id1661_itemsToRemoveOvernight;

	private string id1784_samBandName;

	private string id1844_isWater;

	private string id1447_farmhandReference;

	private string id1472_treeNutShot;

	private string id847_buttonBPosition;

	private string id1729_HoldDownClick;

	private string id1000_qiGems;

	private string id919_itemsLostLastDeath;

	private string id850_mouseRight;

	private string id801_inventorySlot1;

	private string id856_isEmoting;

	private string id1367_temporaryJunimo;

	private string id1590_blanks;

	private string id1718_gravity;

	private string id1788_goldenWalnuts;

	private string id124_Farmer;

	private string id23_int;

	private string id125_FarmerPair;

	private string id262_NetLocationRef;

	private string id1259_slipperiness;

	private string id1659_farmPerfect;

	private string id1283_c;

	private string id218_Ghost;

	private string id381_Tent;

	private string id1662_mailToRemoveOvernight;

	private string id546_furniture_type;

	private string id408_SynchronizedShopStock;

	private string id256_Item;

	private string id377_HoeDirt;

	private string id968_miningLevel;

	private string id1180_Proposer;

	private string id28_ArrayOfRectangle;

	private string id853_ArrayOfCharacter;

	private string id1251_endOfRouteMessage;

	private string id880_produceQuality;

	private string id695_goodFriends;

	private string id1733_SavedTime;

	private string id788_actionButton;

	private string id438_Y;

	private string id851_uid;

	private string id1272_cursedDoll;

	private string id350_FishObjective;

	private string id603_displayItem;

	private string id1306_alpha;

	private string id398_Pickaxe;

	private string id276_PreserveType;

	private string id485_uses;

	private string id117_TopazEnchantment;

	private string id1431_animalsThatLiveHere;

	private string id1542_preSelectedItems;

	private string id1217_daysAfterLastBirth;

	private string id616_currentParentTileIndex;

	private string id1498_greenhouseUnlocked;

	private string id119_WateringCanEnchantment;

	private string id193_Racer;

	private string id460_tileLocation;

	private string id495_indexInTileSheet;

	private string id623_numAttachmentSlots;

	private string id1383_upgradeName;

	private string id1218_birthday_Season;

	private string id813_toolbarSwap;

	private string id453_itemId;

	private string id717_stumpsChopped;

	private string id1187_elevator;

	private string id890_parentId;

	private string id366_SpecialOrderStatus;

	private string id1452_flying;

	private string id161_DesertFestival;

	private string id702_itemsShipped;

	private string id1085_NetLeaderboards;

	private string id303_Sign;

	private string id1369_whichJunimoFromThisHut;

	private string id632_minDamage;

	private string id551_drawHeldObjectLow;

	private string id13_NetClock;

	private string id130_SleepAnnounceModes;

	private string id1307_voice;

	private string id1328_leapEndPosition;

	private string id687_dirtHoed;

	private string id635_addedPrecision;

	private string id147_BathHousePool;

	private string id990_recipesCooked;

	private string id275_Object;

	private string id592_lockOnSuccess;

	private string id1425_input;

	private string id1688_calicoStatueEffects;

	private string id1649_largestSpriteWidth;

	private string id846_buttonAPosition;

	private string id90_CrusaderEnchantment;

	private string id1832_farmerFriendships;

	private string id1246_IsWalkingInSquare;

	private string id1579_dropBoxTileLocation;

	private string id240_MovieInvitation;

	private string id7_FurnitureID;

	private string id1782_locations;

	private string id764_vsyncEnabled;

	private string id84_BaseEnchantment;

	private string id1317_readyToMate;

	private string id1190_buildingLocation;

	private string id1755_startingRotation;

	private string id573_phaseDays;

	private string id1628_Paused;

	private string id708_preservesMade;

	private string id1635_randomOffset;

	private string id1506_museumPieces;

	private string id1496_farmCaveReady;

	private string id1209_treatAsOutdoors;

	private string id646_fuelLeft;

	private string id1830_junimoChest;

	private string id1653_individualMoney;

	private string id477_flipped;

	private string id882_happiness;

	private string id941_whichPetType;

	private string id935_hasSkullKey;

	private string id2_Item;

	private string id51_FishPond;

	private string id1231_followSchedule;

	private string id1165_TutorialShopLocation;

	private string id309_WoodChipper;

	private string id541_maxHealth;

	private string id1421_noHarvest;

	private string id325_ItemHarvestQuest;

	private string id1286_canMoveTimer;

	private string id339_SaveMigrator_1_6;

	private string id483_boundingBox;

	private string id1706_tripping;

	private string id1762_uniqueID;

	private string id1621_monster;

	private string id1300_projectiles;

	private string id840_positionButtonB;

	private string id1432_bridgeFixed;

	private string id709_prismaticShardsFound;

	private string id1087_SaveablePairOfInt32MineInfo;

	private string id467_questId;

	private string id1380_currentOccupants;

	private string id207_Bat;

	private string id1503_MarnieLivestockArea;

	private string id1728_Direction;

	private string id1473_shouldToggleResort;

	private string id1444_cellarWarps;

	private string id1809_dishOfTheDay;

	private string id1_BigCraftableID;

	private string id1815_builders;

	private string id772_enableFarmhandCreation;

	private string id720_totalMoneyGifted;

	private string id1139_AnimationType;

	private string id1046_completed;

	private string id406_Item;

	private string id915_timeWentToBed;

	private string id412_WorldDate;

	private string id138_Item;

	private string id1750_locationName;

	private string id753_gamepadControls;

	private string id336_SaveMigrator_1_3;

	private string id1462_batRestored;

	private string id691_giftsGiven;

	private string id1538_hasUnlockedStatue;

	private string id1484_shippingBinPosition;

	private string id1041__currentObjective;

	private string id1722_uids;

	private string id1292_timeUntilNextAttack;

	private string id631_CastDirection;

	private string id1800_dailyLuck;

	private string id1776_debuffIntensity;

	private string id1678_luauIngredients;

	private string id491_destroyOvernight;

	private string id959_pantsItem;

	private string id521_Item;

	private string id562_isDestroyedByNPCTrample;

	private string id1059_indexToCraft;

	private string id241_MovieViewerLockEvent;

	private string id1257_damageToFarmer;

	private string id1030_runSpeedLevel;

	private string id1643_hairstyleSourceRect;

	private string id1554_requester;

	private string id543_gatePosition;

	private string id907_songsHeard;

	private string id544_gateMotion;

	private string id802_inventorySlot2;

	private string id106_PanEnchantment;

	private string id1262_missChance;

	private string id595_isIslandShrinePedestal;

	private string id1622_numberToKill;

	private string id1156_ArrayOfNetLeaderboardsEntry;

	private string id104_MasterEnchantment;

	private string id1481_farmhouseRestored;

	private string id1617_resource;

	private string id1767_ignoreCharacterCollisions;

	private string id1624_whoToGreet;

	private string id497_appliedBootSheetIndex;

	private string id950_facialHair;

	private string id71_Chunk;

	private string id553_topIndex;

	private string id1562_questState;

	private string id1420_cropHarvestRadius;

	private string id787_serverPrivacy;

	private string id376_Grass;

	private string id120_WeaponSpeedEnchantment;

	private string id932_hasMagicInk;

	private string id707_piecesOfTrashRecycled;

	private string id1494_housePaintColor;

	private string id1525_ElevatorLightSpot;

	private string id163_FarmCave;

	private string id569_state;

	private string id761_Item;

	private string id506_R;

	private string id298_MiniJukebox;

	private string id711_rabbitWoolProduced;

	private string id114_SlimeGathererEnchantment;

	private string id168_IslandFarmCave;

	private string id577_indexOfHarvest;

	private string id1841_tutorialData;

	private string id1573_description;

	private string id278_BedType;

	private string id156_Cellar;

	private string id825_showToggleJoypadButton;

	private string id895_questLog;

	private string id1695_shakeTimer;

	private string id742_autoRun;

	private string id618_instantUse;

	private string id1267_stunTime;

	private string id1039_waveTimer;

	private string id1339_numberOfShotsPerFire;

	private string id219_GhostVariant;

	private string id929_canUnderstandDwarves;

	private string id296_ItemPedestal;

	private string id985_Item;

	private string id108_PowerfulEnchantment;

	private string id323_HaveBuildingQuest;

	private string id158_CommunityCenter;

	private string id418_StopBehavior;

	private string id1311_nextParticle;

	private string id215_DustSpirit;

	private string id1833_timesFedRaccoons;

	private string id1168_anyType;

	private string id312_GamepadModes;

	private string id1474_resortOpenToday;

	private string id1334_shooting;

	private string id866_Gender;

	private string id559_bush;

	private string id1626_Field;

	private string id532_specialChestType;

	private string id1663_cellarAssignments;

	private string id1009_disconnectDay;

	private string id113_ShearsEnchantment;

	private string id769_useAlternateFont;

	private string id1258_resilience;

	private string id765_fullscreen;

	private string id164_FarmHouse;

	private string id1214_Animals;

	private string id77_AmethystEnchantment;

	private string id1585_targetNames;

	private string id528_giftboxIsStarterGift;

	private string id1434__plankPosition;

	private string id1174_LastGiftDate;

	private string id1287_projectileIntroTimer;

	private string id1691_festivalScoreStatus;

	private string id1568_multiplier;

	private string id1546_participantsIDs;

	private string id1134_Item;

	private string id818_vibrations;

	private string id1068_objective;

	private string id1719__tripLeaps;

	private string id466_questItem;

	private string id1713_frame;

	private string id1096_Attribute;

	private string id187_Mine;

	private string id1188_buildingType;

	private string id1436_animationState;

	private string id1839_Item;

	private string id1479_drinksClaimed;

	private string id1330_reviveTimer;

	private string id926_userID;

	private string id529_spriteIndexOverride;

	private string id611_depositedItem;

	private string id382_TerrainFeature;

	private string id522_tint;

	private string id1650_largestSpriteHeight;

	private string id35_NotImplicitNetFieldAttribute;

	private string id33_Vector2;

	private string id1689_junimoKartStatus;

	private string id1293_firing;

	private string id433_animationDirection;

	private string id876_friendshipTowardFarmer;

	private string id1493_raceTrack;

	private string id1640_destroyedTerrainFeature;

	private string id1816_bannedUsers;

	private string id364_ResetEventReward;

	private string id1216_lastCrossroad;

	private string id1149_item;

	private string id538_bait;

	private string id575_phaseToShow;

	private string id277_BedFurniture;

	private string id980_houseUpgradeLevel;

	private string id362_ObjectReward;

	private string id32_ArrayOfVector2;

	private string id1761_projectileID;

	private string id550_defaultBoundingBox;

	private string id394_MagnifyingGlass;

	private string id1316_cute;

	private string id170_IslandFieldOffice;

	private string id1737_isRaining;

	private string id1419_hasSpawnedFish;

	private string id492_displayNameFormat;

	private string id274_NumberSprite;

	private string id210_Bug;

	private string id911_mailReceived;

	private string id1136_Item;

	private string id285_ClothesType;

	private string id480_lastOutputRuleId;

	private string id331_SlayMonsterQuest;

	private string id1319_animateTimer;

	private string id1842_shopLocationsVisited;

	private string id224_LavaLurkState;

	private string id1344_damageSound;

	private string id596_displayNameOverride;

	private string id92_DiamondEnchantment;

	private string id89_CritPowerEnchantment;

	private string id354_OrderObjective;

	private string id1584_useShipmentValue;

	private string id834_joystickConfigs;

	private string id1745_IsRaining;

	private string id1435__plankDirection;

	private string id334_SaveGame;

	private string id1433_gateRect;

	private string id50_Coop;

	private string id1154_ArrayOfMineInfo;

	private string id767_showClearBackgrounds;

	private string id1475_resortRestored;

	private string id44_BuffEffects;

	private string id900_cookingRecipes;

	private string id701_itemsForaged;

	private string id898_experiencePoints;

	private string id1536_ascending;

	private string id1013_recoveredItem;

	private string id1366_holdingBundle;

	private string id715_stepsTaken;

	private string id18_ArrayOfFloat;

	private string id1819_options;

	private string id1336_nextShot;

	private string id1406_Color3Lightness;

	private string id1667_completedSpecialOrders;

	private string id64_Dog;

	private string id535_Item;

	private string id1608_WeaponPrecisionMultiplier;

	private string id75_Crop;

	private string id1483_farmObelisk;

	private string id1603_Immunity;

	private string id1322_firstGeneration;

	private string id745_showMerchantPortraits;

	private string id1515_mapImageSource;

	private string id1559_mailToRemoveOnEnd;

	private string id201_WizardHouse;

	private string id1798_year;

	private string id749_Item;

	private string id1786_worldStateIDs;

	private string id61_Character;

	private string id1773_IgnoreLocationCollision;

	private string id1637_createBolt;

	private string id1476_westernTurtleMoved;

	private string id1075_TweenOfSingle;

	private string id681_chickenEggsLayed;

	private string id367_StackDrawType;

	private string id1548_donatedItems;

	private string id871_IsEmoting;

	private string id1544_objectives;

	private string id1256_timeBeforeAIMovementAgain;

	private string id11_ArrayOfUnsignedByte;

	private string id1739_isLightning;

	private string id1735_weatherForTomorrow;

	private string id455_isRecipe;

	private string id1639_smallFlash;

	private string id1155_Item;

	private string id945_emoteFavorites;

	private string id1510_ladderHasSpawned;

	private string id264_NetNPCRef;

	private string id1044_rewardDescription;

	private string id1408_lastUnlockedPopulationGate;

	private string id1142_LanguageCode;

	private string id1614_locationOfItem;

	private string id1390_animalDoorOpenAmount;

	private string id428_position;

	private string id234_ShadowGuy;

	private string id316_Preconditions;

	private string id1042__questDescription;

	private string id1808_soundVolume;

	private string id1147_ArrayOfBuilderData;

	private string id1010_disconnectLocation;

	private string id723_seedsSown;

	private string id693_goatMilkProduced;

	private string id822_xEdge;

	private string id1740_isDebrisWeather;

	private string id971_fishingLevel;

	private string id704_mysticStonesCrushed;

	private string id1348_fireRange;

	private string id1725_ChestTile;

	private string id1101_ArrayOfHat;

	private string id748_alwaysShowToolHitLocation;

	private string id1605_WeaponSpeedMultiplier;

	private string id1198_resourceClumps;

	private string id159_DecoratableLocation;

	private string id1049_canBeCancelled;

	private string id1707_drawAboveMap;

	private string id310_Workbench;

	private string id542_whichType;

	private string id1804_hasApplied1_3_UpdateChanges;

	private string id3_CHJsonParser;

	private string id819_bigNumbers;

	private string id516_daysToMature;

	private string id1845_isVisible;

	private string id395_MeleeWeapon;

	private string id1656_mineShrineActivated;

	private string id734_gamepadMode;

	private string id1834_treasureTotemsUsed;

	private string id578_dayOfCurrentPhase;

	private string id1780_player;

	private string id270_NewDaySynchronizer;

	private string id1540_invitedNPC;

	private string id374_FruitTree;

	private string id1672_globalInventories;

	private string id1514_fogPos;

	private string id190_Mountain;

	private string id914_locationsVisited;

	private string id1302_active;

	private string id513_previousEnchantments;

	private string id1143_TileNeighbors;

	private string id427_Season;

	private string id1450_waterSpots;

	private string id1781_farmhands;

	private string id153_BusStop;

	private string id614_combinedRings;

	private string id283_SpecialChestTypes;

	private string id602_swappedWithFarmerTonight;

	private string id1170_value;

	private string id1015_deepestMineLevel;

	private string id785_preferredResolutionX;

	private string id1704_jumpSegmentEnd;

	private string id1487_numberOfStarsOnPlaque;

	private string id1517_recentlyActivatedCalicoStatue;

	private string id1504_log;

	private string id232_ShadowBrute;

	private string id38_AnimalHouse;

	private string id554_middleIndex;

	private string id68_Pet;

	private string id386_TokenParser;

	private string id1242_squareMovementFacingPreference;

	private string id1284_nextFire;

	private string id111_RubyEnchantment;

	private string id335_SaveFixes;

	private string id692_goatCheeseMade;

	private string id1243_DirectionsToNewLocation;

	private string id1651_sortMode;

	private string id1443_fridgePosition;

	private string id1732_Milliseconds;

	private string id1386_buildingChests;

	private string id1698_direction;

	private string id1373_indoors;

	private string id281_Cask;

	private string id552_bedType;

	private string id401_Slingshot;

	private string id1355_isSleepingOnFarmerBed;

	private string id1036_whichWave;

	private string id906_secretNotesSeen;

	private string id741_clientOptions;

	private string id1611_whereToGo;

	private string id378_HoeDirtFertilizerApplyStatus;

	private string id794_moveLeftButton;

	private string id450_hasBeenInInventory;

	private string id1840_lastAppliedSaveFix;

	private string id523_playerChoiceColor;

	private string id1004_saveTime;

	private string id828_daysSinceReviewRequest;

	private string id1249_facingDirection;

	private string id1061_targetMessage;

	private string id226_MetalHead;

	private string id1771_light;

	private string id607_trinketMetadata;

	private string id731_timesPlayed;

	private string id972_luckLevel;

	private string id565_tileSheetOffset;

	private string id265_NetPosition;

	private string id476_showNextIndex;

	private string id582_flip;

	private string id999_yearForSaveGame;

	private string id358_FriendshipReward;

	private string id598_shirt;

	private string id1763_ignoreTravelGracePeriod;

	private string id60_ChangeType;

	private string id727_levelTenForaging;

	private string id726_levelTenMining;

	private string id1064_numberFished;

	private string id1829_junimoKartLeaderboards;

	private string id868_Position;

	private string id55_Mill;

	private string id1175_TalkedToToday;

	private string id636_addedDefense;

	private string id178_IslandSouthEast;

	private string id993_giftedItems;

	private string id1074_TweenOfQuaternion;

	private string id313_ItemStowingModes;

	private string id967_farmingLevel;

	private string id1320_timeSinceLastJump;

	private string id650_stump;

	private string id1535_submerged;

	private string id1564_amount;

	private string id1269_ignoreDamageLOS;

	private string id760_snappyMenus;

	private string id1023_CursorSlotItem;

	private string id251_ChestHitTimer;

	private string id664_greenHouseTileTree;

	private string id739_safeRegionSize;

	private string id29_Rectangle;

	private string id416_FloatTween;

	private string id1567_host;

	private string id337_SaveMigrator_1_4;

	private string id975_lastSeenMovieWeek;

	private string id493_defenseBonus;

	private string id777_footstepVolumeLevel;

	private string id451_name;

	private string id217_Fly;

	private string id1746_IsSnowing;

	private string id966_caveChoice;

	private string id17_double;

	private string id20_ArrayOfGuid;

	private string id185_ManorHouse;

	private string id1314_randomStackOffset;

	private string id1537_daysUntilCommunityUpgrade;

	private string id1173_GiftsToday;

	private string id267_NetWitnessedLock;

	private string id1324_leapDuration;

	private string id469_fragility;

	private string id783_uiScale;

	private string id1769_startingScale;

	private string id930_hasClubCard;

	private string id1361_checkActionEnabled;

	private string id730_Item;

	private string id699_itemsCooked;

	private string id1591_LogSounds;

	private string id1378_tilesHigh;

	private string id1029_spreadPistol;

	private string id475_readyForHarvest;

	private string id212_AttackState;

	private string id861_faceTowardFarmer;

	private string id348_DeliverObjective;

	private string id849_mouseLeft;

	private string id301_RandomizedPlantFurniture;

	private string id1785_elliottBookName;

	private string id385_TranslationValidatorIssue;

	private string id928_catPerson;

	private string id829_reviewGiven;

	private string id1685_useLegacyRandom;

	private string id425_Year;

	private string id1717_extraLuck;

	private string id1388_animalDoor;

	private string id780_dialogueFontScale;

	private string id1186_coalCartsLeft;

	private string id1131_Item;

	private string id1095_Vector3;

	private string id854_npcGroups;

	private string id100_HoeEnchantment;

	private string id1211_miniJukeboxCount;

	private string id56_PetBowl;

	private string id236_Shooter;

	private string id179_IslandSouthEastCave;

	private string id1456_puzzleFinished;

	private string id444_npcOnly;

	private string id1092_PlayerStatusList;

	private string id1236_shouldWearIslandAttire;

	private string id1080_XmlSerializationWriter;

	private string id545_isGate;

	private string id1003_chestConsumedLevels;

	private string id925_slotCanHost;

	private string id500_dyeable;

	private string id115_SlimeSlayerEnchantment;

	private string id1486_areasComplete;

	private string id1005_isCustomized;

	private string id1684_spawnMonstersAtNight;

	private string id1084_Item;

	private string id1263_isGlider;

	private string id1291_isArmoredBug;

	private string id807_inventorySlot7;

	private string id539_tileIndexToShow;

	private string id1460_centerSkeletonRestored;

	private string id1583_skullCave;

	private string id175_IslandSecret;

	private string id150_BoatTunnel;

	private string id921_farmName;

	private string id570_fertilizer;

	private string id962_gameVersion;

	private string id67_JunimoHarvester;

	private string id1541_fulfilled;

	private string id1321_specialNumber;

	private string id651_tapped;

	private string id873_Scale;

	private string id328_Quest;

	private string id1016_stamina;

	private string id594_match;

	private string id1427_petGuid;

	private string id751_pinToolbarToggle;

	private string id903_previousActiveDialogueEvents;

	private string id609_isFloor;

	private string id893_isEating;

	private string id464_canBeGrabbed;

	private string id88_CritEnchantment;

	private string id1777_accumulator;

	private string id290_FishTankFurniture;

	private string id1843_showTutorials;

	private string id938_hasUnlockedSkullDoor;

	private string id1609_AppliedBuffIds;

	private string id536_Item;

	private string id293_Hat;

	private string id1634_ySpriteSheet;

	private string id1315_leftDrift;

	private string id80_ArtfulEnchantment;

	private string id997_dayOfMonthForSaveGame;

	private string id1464_plantsRestoredLeft;

	private string id1500_spousePatioSpot;

	private string id1365_holdingStar;

	private string id1429_talkedToGil;

	private string id653_hasMoss;

	private string id46_BuildingPaintColor;

	private string id213_BreathProjectile;

	private string id973_maxStamina;

	private string id424_WeaponControl;

	private string id1446_farmhand;

	private string id183_JojaMart;

	private string id1461_snakeRestored;

	private string id315_SchedulePathDescription;

	private string id988_basicShipped;

	private string id343_Vector2Writer;

	private string id855_forceOneTileWide;

	private string id1102_ArrayOfClothing;

	private string id1097_ArrayOfBuilding;

	private string id755_ambientOnlyToggle;

	private string id1227_datable;

	private string id439_Width;

	private string id1164_ArrayOfTutorialType;

	private string id487_orderData;

	private string id248_BuilderData;

	private string id434_animationIntervalOffset;

	private string id579_whichForageCrop;

	private string id1106_ArrayOfBreathProjectile;

	private string id1703_jumpSegmentStart;

	private string id1226_divorcedFromFarmer;

	private string id1078_XmlSerializer;

	private string id291_FishTankCategories;

	private string id1111_ArrayOfNPC;

	private string id1108_ArrayOfQuest;

	private string id1675_sleepAnnounceMode;

	private string id1360_ownerId;

	private string id1081_XmlSerializationReader;

	private string id1345_fireSound;

	private string id284_Clothing;

	private string id1438_hasSpawnedBugsToday;

	private string id27_Point;

	private string id1308_hard;

	private string id1028_ammoLevel;

	private string id1810_highestPlayerLimit;

	private string id1757_acceleration;

	private string id1045_accepted;

	private string id1813_hasDedicatedHost;

	private string id1295_nextFireTime;

	private string id1082_SaveablePairOfInt32Int64;

	private string id1545_seenParticipantsIDs;

	private string id1270_isHardModeMonster;

	private string id1715_burstDuration;

	private string id1463_frogRestored;

	private string id146_AdventureGuild;

	private string id671_textureName;

	private string id1742_monthlyNonRainyDayCount;

	private string id200_Town;

	private string id1837_raccoonBundles;

	private string id1491_drivingBack;

	private string id1606_CriticalChanceMultiplier;

	private string id572_crop;

	private string id347_CollectObjective;

	private string id1022_spouse;

	private string id242_Item;

	private string id1145_ArrayOfInputButton;

	private string id1596_LuckLevel;

	private string id1070_param;

	private string id1428_Gil;

	private string id874_isSwimming;

	private string id750_pauseWhenOutOfFocus;

	private string id208_BigSlime;

	private string id909_specialItems;

	private string id1673_globalInventoryMutexes;

	private string id1574_failOnCompletion;

	private string id233_ShadowGirl;

	private string id1636_boltPosition;

	private string id345_Shed;

	private string id1035_whichRound;

	private string id1138_DisplayMode;

	private string id107_PickaxeEnchantment;

	private string id724_startMuted;

	private string id817_greenSquaresGuide;

	private string id1731_RecentlyHit;

	private string id1495_grandpaScore;

	private string id152_BugLand;

	private string id805_inventorySlot5;

	private string id505_G;

	private string id1528_isMonsterArea;

	private string id15_Color;

	private string id1356_CurrentBehavior;

	private string id449_category;

	private string id624_attachments;

	private string id951_lastGotPrizeFromGil;

	private string id1338_projectileDebuff;

	private string id1549_appliedSpecialRules;

	private string id957_rightRing;

	private string id1521_mineLevel;

	private string id1736_weather;

	private string id1560_dueDate;

	private string id875_currentProduce;

	private string id1167_ArrayOfAnyType;

	private string id9_ArrayOfBoolean;

	private string id1570_resetEvents;

	private string id1225_datingFarmer;

	private string id1037_heldItem;

	private string id1024_UniqueMultiplayerID;

	private string id1440_appliedWallpaper;

	private string id1285_squidYOffset;

	private string id63_Child;

	private string id599_pants;

	private string id1775_wavyMotion;

	private string id1181_RoommateMarriage;

	private string id95_FisherEnchantment;

	private string id940_daysMarried;

	private string id1150_Item;

	private string id1550_rewards;

	private string id1738_isSnowing;

	private string id94_EmeraldEnchantment;

	private string id1674_announcedSleepingFarmers;

	private string id78_AquamarineEnchantment;

	private string id1665_constructedBuildings;

	private string id1551_questKey;

	private string id524_playerChest;

	private string id21_guid;

	private string id1407_fishType;

	private string id964_bibberstyke;

	private string id981_daysUntilHouseUpgrade;

	private string id1337_projectileSpeed;

	private string id560_TileLocation;

	private string id1375_tileX;

	private string id1616_numberCollected;

	private string id1654_newLostAndFoundItems;

	private string id1492_leaving;

	private string id286_ColoredObject;

	private string id1791_goldenCoconutCracked;

	private string id1644_hatSourceRect;

	private string id561_tilePosition;

	private string id1459_piecesDonated;

	private string id1820_splitscreenOptions;

	private string id254_IncomingMessage;

	private string id1020_theaterBuildDate;

	private string id1633_xSpriteSheet;

	private string id920_movementDirections;

	private string id279_Boots;

	private string id384_TranslationValidator;

	private string id456_quality;

	private string id349_DonateObjective;

	private string id1228_defaultMap;

	private string id160_Desert;

	private string id685_daysPlayed;

	private string id1720_progress;

	private string id1197_objects;

	private string id910_specialBigCraftables;

	private string id490_honeyType;

	private string id365_SpecialOrder;

	private string id1533_dayFirstEntered;

	private string id332_SocializeQuest;

	private string id499_clothesType;

	private string id1648_iconAnimationFrames;

	private string id314_PriorityQueue;

	private string id1430_animalLimit;

	private string id983_hasWateringCanEnchantment;

	private string id473_setOutdoors;

	private string id994_tailoredItems;

	private string id1680_limitedNutDrops;

	private string id1423_raisinDays;

	private string id488_preserve;

	private string id1796_shuffleMineChests;

	private string id1580_minimumCapacity;

	private string id571_Tile;

	private string id697_iridiumFound;

	private string id558_hoeDirt;

	private string id979_daysLeftForToolUpgrade;

	private string id1414_neededItem;

	private string id1116_Item;

	private string id816_autoAttack;

	private string id1384_buildingPaintColor;

	private string id1571_currentCount;

	private string id839_positionButtonA;

	private string id459_SpecialVariable;

	private string id429_sourceRect;

	private string id1011_disconnectPosition;

	private string id253_DedicatedServerMessageType;

	private string id1794_checkedGarbage;

	private string id1235_shouldPlaySpousePatioAnimation;

	private string id776_soundVolumeLevel;

	private string id1690_endOfNightStatus;

	private string id247_NetSynchronizer;

	private string id1543_selectedRandomElements;

	private string id1208_ignoreLights;

	private string id1803_shouldSpawnMonsters;

	private string id392_Hoe;

	private string id800_journalButton;

	private string id1353_grantedFriendshipForPet;

	private string id1471_caveOpened;

	private string id132_Friendship;

	private string id1547_unclaimedRewardsIDs;

	private string id1814_locationWeather;

	private string id1823_mine_lowestLevelReached;

	private string id420_Vector2Tween;

	private string id663_struckByLightningCountdown;

	private string id1194_animals;

	private string id149_BeachNightMarket;

	private string id732_windowMode;

	private string id1237_isMovingOnPathFindPath;

	private string id437_X;

	private string id1770_scaleGrow;

	private string id243_Item;

	private string id1741_isGreenRain;

	private string id1705_jumping;

	private string id634_speed;

	private string id1268_initializedForLocation;

	private string id1449_slimeMatingsLeft;

	private string id1115_Item;

	private string id1277_lungeChargeTime;

	private string id205_MineChestType;

	private string id457_stack;

	private string id872_CurrentEmote;

	private string id203_MapSeat;

	private string id461_owner;

	private string id82_AutoHookEnchantment;

	private string id10_boolean;

	private string id157_Club;

	private string id4_ContentHashParser;

	private string id703_monstersKilled;

	private string id239_SquidKid;

	private string id630_additionalPower;

	private string id1555_orderType;

	private string id548_currentRotation;

	private string id984_temporaryInvincibilityTimer;

	private string id1734_CheckedHostPrecondition;

	private string id1404_Color3Hue;

	private string id141_IslandGemBird;

	private string id6_DontLoadDefaultSetting;

	private string id642_isOnSpecial;

	private string id231_Serpent;

	private string id1457_gourmandRequestsFulfilled;

	private string id1403_Color3Default;

	private string id1751_boundingBoxWidth;

	private string id1255__locationNames;

	private string id1723_movieStartTime;

	private string id421_Vector3Tween;

	private string id368_StartMovieEvent;

	private string id1756_alphaChange;

	private string id779_snowTransparency;

	private string id409_ToolSpamInputSimulator;

	private string id768_useChineseSmoothFont;

	private string id674_specificMonstersKilled;

	private string id1824_whichFarm;

	private string id320_DescriptionElement;

	private string id65_Horse;

	private string id1604_KnockbackMultiplier;

	private string id197_ShopLocation;

	private string id1511_ghostAdded;

	private string id430_which;

	private string id1157_ArrayOfArrayOfItem;

	private string id1144_FishType;

	private string id189_MineShaft;

	private string id1158_Item;

	private string id1812_allowChatCheats;

	private string id555_bottomIndex;

	private string id36_NotNetFieldAttribute;

	private string id1183_Farmer2;

	private string id1347_desiredDistance;

	private string id1402_Color2Lightness;

	private string id525_fridge;

	private string id324_ItemDeliveryQuest;

	private string id1305_rotation;

	private string id452_parentSheetIndex;

	private string id1601_Attack;

	private string id870_FacingDirection;

	private string id1107_ArrayOfVector3;

	private string id131_Fence;

	private string id677_averageBedtime;

	private string id1326_leaping;

	private string id1398_Color1Lightness;

	private string id509_skipHairDraw;

	private string id1248_time;

	private string id341_Vector2Reader;

	private string id1201_uniqueName;

	private string id963_gameVersionLabel;

	private string id229_RockCrab;

	private string id1532_fogColor;

	private string id297_Mannequin;

	private string id359_GemsReward;

	private string id1179_Status;

	private string id589_overrideTexturePath;

	private string id606_Item;

	private string id110_ReachingToolEnchantment;

	private string id943_acceptedDailyQuest;

	private string id361_MoneyReward;

	private string id637_addedAreaOfEffect;

	private string id1357_daysOld;

	private string id1166_ArrayOfTutorialShopLocation;

	private string id1223_sleptInBed;

	private string id1702_segmentEnd;

	private string id641_appearance;

	private string id1790_miniShippingBinsObtained;

	private string id97_GalaxySoulEnchantment;

	private string id445_TargetX;

	private string id1563_targetName;

	private string id1797_dayOfMonth;

	private string id902_activeDialogueEvents;

	private string id810_inventorySlot10;

	private string id1110_ArrayOfWorldDate;

	private string id1313_stackedSlimes;

	private string id1391_magical;

	private string id976_clubCoins;

	private string id728_levelTenCombat;

	private string id1282_lungeVelocity;

	private string id710_questsCompleted;

	private string id126_FarmerRenderer;

	private string id375_GiantCrop;

	private string id371_Bush;

	private string id1091_Item;

	private string id942_whichPetBreed;

	private string id1641_heightOffset;

	private string id1779_maxEntries;

	private string id1018_millisecondsPlayed;

	private string id660_daysUntilMature;

	private string id970_foragingLevel;

	private string id1364_friendly;

	private string id53_IndoorsType;

	private string id1079_XmlSerializationGeneratedCode;

	private string id927_defaultChatColor;

	private string id1343_firedProjectile;

	private string id889_ownerID;

	private string id556_heldItems;

	private string id360_MailReward;

	private string id1598_MaxStamina;

	private string id1275_canLunge;

	private string id295_IndoorPot;

	private string id814_emoteButton;

	private string id859_coloredBorder;

	private string id775_musicVolumeLevel;

	private string id740_languageCode;

	private string id431_animationIndex;

	private string id441_Location;

	private string id223_LavaLurk;

	private string id1655_toggleMineShrineOvernight;

	private string id1593_FarmingLevel;

	private string id1799_countdownToWedding;

	private string id122_LightningStrikeEvent;

	private string id1200_terrainFeatures;

	private string id955_newEyeColor;

	private string id1836_seasonOfCurrentRaccoonBundle;

	private string id796_runButton;

	private string id842_joystickSize;

	private string id1294_attackState;

	private string id1260_experienceGained;

	private string id686_diamondsFound;

	private string id1826_skullCavesDifficulty;

	private string id1160_ArrayOfFriendship;

	private string id798_chatButton;

	private string id662_fruit;

	private string id482_minutesUntilReady;

	private string id181_IslandWestCave1;

	private string id1327_leapStartPosition;

	private string id1056_completionString;

	private string id54_JunimoHut;

	private string id123_FarmAnimal;

	private string id718_timesFished;

	private string id1358_idOfParent;

	private string id351_GiftObjective;

	private string id626_IndexOfMenuItemView;

	private string id128_FarmerTeam;

	private string id435_dx;

	private string id1244_DefaultFacingDirection;

	private string id1455_bananaShrineNutAwarded;

	private string id716_stoneGathered;

	private string id1835_perfectionWaivers;

	private string id922_favoriteThing;

	private string id1130_ArrayOfMovieInvitation;

	private string id145_AbandonedJojaMart;

	private string id584_raisedSeeds;

	private string id1638_bigFlash;

	private string id136_InstancedStatic;

	private string id897_newLevels;

	private string id864_glowingTransparency;

	private string id1103_ArrayOfBoots;

	private string id946_hair;

	private string id762_showMPEndOfNightReadyStatus;

	private string id675_Values;

	private string id402_Wand;

	private string id1161_Item;

	private string id1362_HorseId;

	private string id289_DefaultPhoneHandler;

	private string id1418_seedOffset;

	private string id1371_mrs_raccoon;

	private string id1727_StandingPixel;

	private string id580_overrideHarvestItemId;

	private string id1730_ToolCanHit;

	private string id905_eventsSeen;

	private string id1368_stayPut;

	private string id763_muteAnimalSounds;

	private string id73_AchievementIds;

	private string id912_mailForTomorrow;

	private string id1501_itemsFromPlayerToSell;

	private string id180_IslandWest;

	private string id400_Shears;

	private string id216_DwarvishSentry;

	private string id1524_tileBeneathElevator;

	private string id1346_projectileRange;

	private string id390_FishingRod;

	private string id49_Building;

	private string id167_IslandEast;

	private string id221_Grub;

	private string id1600_Defense;

	private string id1199_largeTerrainFeatures;

	private string id1505_stumpFixed;

	private string id867_willDestroyObjectsUnderfoot;

	private string id1133_Item;

	private string id1205_isStructure;

	private string id140_items;

	private string id939_friendships;

	private string id1709_minMoveSpeed;

	private string id344_ServerPrivacy;

	private string id1254__route;

	private string id684_cropsShipped;

	private string id1607_CriticalPowerMultiplier;

	private string id209_BlueSquid;

	private string id852_playerGroups;

	private string id1394_ColorName;

	private string id447_TargetName;

	private string id1671_returnedDonations;

	private string id1014_isMale;

	private string id389_ErrorTool;

	private string id1612_number;

	private string id527_giftboxIndex;

	private string id901_craftingRecipes;

	private string id823_toolbarPadding;

	private string id1561_duration;

	private string id237_Skeleton;

	private string id317_DebuffingProjectile;

	private string id1699_horizontalPosition;

	private string id916_sleptInTemporaryBed;

	private string id894_displayName;

	private string id679_caveCarrotsFound;

	private string id1805_hasApplied1_4_UpdateChanges;

	private string id426_DayOfMonth;

	private string id986_difficultyModifier;

	private string id1376_tileY;

	private string id878_age;

	private string id93_EfficientToolEnchantment;

	private string id266_ReadySynchronizer;

	private string id1370_HomeId;

	private string id835_sizeJoystick;

	private string id1806_weddingsToday;

	private string id1489_bundleRewards;

	private string id1333_Z;

	private string id222_HotHead;

	private string id1721_sabotages;

	private string id39_LoopingCueManager;

	private string id738_lastEnteredIP;

	private string id1094_Random;

	private string id1215_IsGreenhouse;

	private string id1060_target;

	private string id1582_minimumLikeLevel;

	private string id991_archaeologyFound;

	private string id1055_nextQuests;

	private string id87_BugKillerEnchantment;

	private string id586_dead;

	private string id58_Stable;

	private string id888_myID;

	private string id1031_lives;

	private string id815_verticalToolbar;

	private string id1701_segmentStart;

	private string id1470_traderActivated;

	private string id486_signText;

	private string id261_ArrayOfLong1;

	private string id1025_money;

	private string id744_showPortraits;

	private string id98_GenerousEnchantment;

	private string id1206_ignoreDebrisWeather;

	private string id1393_isMoving;

	private string id1409_hasCompletedRequest;

	private string id1002_trinketItem;

	private string id1178_NextBirthingDate;

	private string id227_Monster;

	private string id1539_farmer;

	private string id327_ArrayOfDescriptionElement;

	private string id1822_mine_permanentMineChanges;

	private string id356_ShipObjective;

	private string id1716_nextBurst;

	private string id436_dy;

	private string id269_Item;

	private string id1465_plantsRestoredRight;

	private string id72_CollisionMask;

	private string id134_GameLocation;

	private string id1104_ArrayOfObject;

	private string id1124_Item;

	private string id174_IslandNorth;

	private string id1795_visitsUntilY1Guarantee;

	private string id1627_Value;

	private string id220_GreenSlime;

	private string id393_Lantern;

	private string id414_TapState;

	private string id37_ObjectID;

	private string id1697_lastPosition;

	private string id590_requiredItem;

	private string id947_skin;

	private string id415_ColorTween;

	private string id1232_moveTowardPlayerThreshold;

	private string id1247_IsWalkingTowardPlayer;

	private string id76_DebugTimings;

	private string id489_preservedParentSheetIndex;

	private string id1399_Color2Default;

	private string id249_ChestHitArgs;

	private string id155_Caldera;

	private string id1122_Item;

	private string id1351_whichBreed;

	private string id448_isLostItem;

	private string id892_moodMessage;

	private string id228_Mummy;

	private string id1397_Color1Saturation;

	private string id357_SlayObjective;

	private string id974_maxItems;

	private string id917_stats;

	private string id1342_aimEndTime;

	private string id463_canBeSetDown;

	private string id600_boots;

	private string id1377_tilesWide;

	private string id1053_daysLeft;

	private string id1252_targetLocationName;

	private string id372_CosmeticPlant;

	private string id1578_dropBoxGameLocation;

	private string id640_critMultiplier;

	private string id1229_loveInterest;

	private string id206_AngryRoger;

	private string id1789_goldenWalnutsFound;

	private string id652_hasSeed;

	private string id706_otherPreciousGemsFound;

	private string id501_clothesColor;

	private string id1312_variant;

	private string id770_ipConnectionsEnabled;

	private string id410_Warp;

	private string id669_width;

	private string id1193_buildings;

	private string id1221_socialAnxiety;

	private string id1687_highestCalicoEggRatingToday;

	private string id1273_hauntedSkull;

	private string id148_Beach;

	private string id1410_goldenAnimalCracker;

	private string id1019_useSeparateWallets;

	private string id1512_loadedDarkArea;

	private string id510_ignoreHairstyleOffset;

	private string id593_locked;

	private string id1726_ToolPosition;

	private string id643_isBottomless;

	private string id1758_maxVelocity;

	private string id622_upgradeLevel;

	private string id1177_WeddingDate;

	private string id1301_lastProjectileSlot;

	private string id1831_shippingBin;

	private string id700_itemsCrafted;

	private string id1382_daysUntilUpgrade;

	private string id733_displayIndex;

	private string id47_BuildingPainter;

	private string id214_Duggy;

	private string id1413_output;

	private string id1802_weddingToday;

	private string id299_PetLicense;

	private string id1714_nextFrameSwap;

	private string id1065_whichFish;

	private string id478_isLamp;

	private string id1458_uncollectedRewards;

	private string id1632_netDebrisType;

	private string id1683_sharedDailyLuck;

	private string id1176_ProposalRejected;

	private string id105_MilkPailEnchantment;

	private string id670_height;

	private string id1556_specialRule;

	private string id1807_musicVolume;

	private string id566_townBush;

	private string id244_NetLogger;

	private string id712_rocksCrushed;

	private string id588_seedIndex;

	private string id773_stowingMode;

	private string id135_InputButton;

	private string id621_swingTicker;

	private string id1827_minesDifficulty;

	private string id863_faceAwayFromFarmer;

	private string id1620_monsterName;

	private string id1668_specialOrders;

	private string id103_MagicEnchantment;

	private string id397_Pan;

	private string id784_localCoopDesiredUIScale;

	private string id422_Vector4Tween;

	private string id1239_islandScheduleName;

	private string id1710_maxMoveSpeed;

	private string id330_SecretLostItemQuest;

	private string id474_setIndoors;

	private string id982_showChestColorPicker;

	private string id1117_ArrayOfWarp;

	private string id1677_movieInvitations;

	private string id1783_currentSeason;

	private string id177_IslandSouth;

	private string id1354_timesPet;

	private string id563_size;

	private string id729_skipWindowPreparation;

	private string id1610_Dirty;

	private string id654_isTemporaryGreenRainTree;

	private string id799_mapButton;

	private string id1379_maxOccupants;

	private string id192_MovieStates;

	private string id778_ambientVolumeLevel;

	private string id1296_totalFireTime;

	private string id70_TrashBear;

	private string id1467_treeNutObtained;

	private string id1329_nextLeap;

	private string id1290_lastRotation;

	private string id1241_previousEndPoint;

	private string id472_bigCraftable;

	private string id211_DinoMonster;

	private string id311_Options;

	private string id1422_wasLit;

	private string id1575_acceptableContextTagSets;

	private string id1289_nearFarmer;

	private string id1825_Item;

	private string id1001_JOTPKProgress;

	private string id507_A;

	private string id891_hasEatenAnimalCracker;

	private string id1266_objectsToDrop;

	private string id1171_Points;

	private string id5_DistanceToTarget;

	private string id1724_IsLogging;

	private string id1202_waterColor;

	private string id534_color;

	private string id1669_availableSpecialOrders;

	private string id432_animationTimer;

	private string id619_isEfficient;

	private string id1066_parts;

	private string id154_Cabin;

	private string id515_agingRate;

	private string id657_whichFloor;

	private string id308_Wallpaper;

	private string id273_NPC;

	private string id754_rumble;

	private string id1569_itemKey;

	private string id820_bigFonts;

	private string id169_IslandFarmHouse;

	private string id627_InstantUse;

	private string id793_moveDownButton;

	private string id722_weedsEliminated;

	private string id1120_ArrayOfChest;

	private string id978_toolBeingUpgraded;

	private string id1748_IsDebrisWeather;

	private string id1513_isFallingDownShaft;

	private string id1152_ArrayOfOptions;

	private string id1381_daysOfConstructionLeft;

	private string id1222_optimism;

	private string id885_wasPet;

	private string id1238_dayScheduleName;

	private string id1264_mineMonster;

	private string id1530_ambientFog;

	private string id1576_message;

	private string id1439_wallPaper;

	private string id1072_TweenOfVector3;

	private string id1063_reward;

	private string id887_buildingTypeILiveIn;

	private string id644_WaterLeft;

	private string id719_timesUnconscious;

	private string id19_float;

	private string id85_BaseWeaponEnchantment;

	private string id682_copperFound;

	private string id1123_Item;

	private string id1071_TweenOfVector4;

	private string id1749_IsGreenRain;

	private string id1488_bundles;

	private string id1754_travelTime;

	private string id1021_timesReachedMineBottom;

	private string id1646_rotationAdjustment;

	private string id1153_Item;

	private string id1127_Item;

	private string id1692_sleepStatus;

	private string id1787_lostBooksFound;

	private string id508_PackedValue;

	private string id1466_hasFailedSurveyToday;

	private string id824_weaponControl;

	private string id583_fullGrown;

	private string id797_tmpKeyToReplace;

	private string id858_isGlowing;

	private string id1401_Color2Saturation;

	private string id403_WateringCan;

	private string id280_BreakableContainer;

	private string id746_showMenuBackground;

	private string id388_Axe;

	private string id1417_nettingStyle;

	private string id195_SeedShop;

	private string id139_Item;

	private string id1599_MagneticRadius;

	private string id333_RainDrop;

	private string id34_NetVersion;

	private string id924_slotName;

	private string id1416_daysSinceSpawn;

	private string id1073_TweenOfVector2;

	private string id1261_jitteriness;

	private string id688_duckEggsLayed;

	private string id1387_humanDoor;

	private string id41_SoundsHelper;

	private string id601_facing;

	private string id1374_nonInstancedIndoorsName;

	private string id271_Noise;

	private string id830_toolbarSlotSize;

	private string id1159_ArrayOfFarmerPair;

	private string id74_StatKeys;

	private string id612_nextSmokeTime;

	private string id1642_shirtSourceRect;

	private string id838_positionJoystick;

	private string id952_lastDesertFestivalFishingQuest;

	private string id383_Tree;

	private string id526_giftbox;

	private string id992_callsReceived;

	private string id960_divorceTonight;

	private string id1299_wanderState;

	private string id1114_ArrayOfFurniture;

	private string id581_tintColor;

	private string id639_critChance;

	private string id540_health;

	private string id1445_cribStyle;

	private string id373_Flooring;

	private string id1048_showNew;

	private string id133_FriendshipStatus;

	private string id1323_prismatic;

	private string id1772_hasLit;

	private string id1359_darkSkinned;

	private string id1129_Item;

	private string id1040_monsterChances;

	private string id1828_currentGemBirdIndex;

	private string id1645_accessorySourceRect;

	private string id737_fullscreenResolutionY;

	private string id668_grassSourceOffset;

	private string id171_IslandForestLocation;

	private string id511_hairDrawType;

	private string id165_FishShop;

	private string id1297_nextChangeDirectionTime;

	private string id904_triggerActionsRun;

	private string id22_ArrayOfInt;

	private string id1631_sinkTimer;

	private string id1163_tutorialType;

	private string id604_displayType;

	private string id306_Trinket;

	private string id756_zoomButtons;

	private string id363_OrderReward;

	private string id1093_Item;

	private string id721_trufflesFound;

	private string id1109_ArrayOfItem;

	private string id1647_positionOffset;

	private string id531_synchronized;

	private string id1234_shouldPlayRobinHammerAnimation;

	private string id1026_bulletDamage;

	private string id257_Item;

	private string id1169_ArrayOfArrayOfCharacter;

	private string id1363_whichArea;

	private string id352_LikeLevels;

	private string id786_preferredResolutionY;

	private string id845_joystickPosition;

	private string id1821_CustomData;

	private string id1335_shotsLeft;

	private string id694_goldFound;

	private string id1712_racerIndex;

	private string id204_MarriageDialogueReference;

	private string id503_Price;

	private string id1588_LocalId;

	private string id1128_Item;

	private string id12_unsignedByte;

	private string id116_SwiftToolEnchantment;

	private string id1105_ArrayOfRing;

	private string id1818_latestID;

	private string id743_dialogueTyping;

	private string id1352_homeLocationName;

	private string id836_sizeButtonA;

	private string id329_ResourceCollectionQuest;

	private string id1038_world;

	private string id318_Projectile;

	private string id1508_fogTime;

	private string id1507_mineRandom;

	private string id24_ArrayOfLong;

	private string id109_PreservingEnchantment;

	private string id977_trashCanLevel;

	private string id696_individualMoneyEarned;

	private string id1586_ignoreFarmMonsters;

	private string id399_Raft;

	private string id1592_CombatLevel;

	private string id1119_ArrayOfBuildingPaintColor;

	private string id81_AttackEnchantment;

	private string id118_VampiricEnchantment;

	private string id1086_NetLeaderboardsEntry;

	private string id1523_tileBeneathLadder;

	private string id843_buttonASize;

	private string id1245_DefaultPosition;

	private string id1400_Color2Hue;

	private string id714_slimesKilled;

	private string id519_frameCounter;

	private string id886_allowReproduction;

	private string id1121_Item;

	private string id1280_nextLunge;

	private string id407_StackTraceHelper;

	private string id1658_skullShrineActivated;

	private string id238_Spiker;

	private string id1309_currentState;

	private string id1189_daysUntilBuilt;

	private string id931_hasDarkTalisman;

	private string id1565_noLetter;

	private string id25_long;

	private string id1619_exclusiveQuestId;

	private string id1454_bananaShrineComplete;

	private string id1253_targetTile;

	private string id1350_petType;

	private string id1146_ArrayOfGameLocation;

	private string id953_hairstyleColor;

	private string id913_mailbox;

	private string id1426_watered;

	private string id827_invisibleButtonWidth;

	private string id1185_chestsLeft;

	private string id597_hat;

	private string id391_GenericTool;

	private string id346_SlimeHutch;

	private string id1274_magmaSprite;

	private string id151_TunnelAnimationState;

	private string id996_dateStringForSaveGame;

	private string id79_ArchaeologistEnchantment;

	private string id613_nextShakeTime;

	private string id995_friendshipData;

	private string id1469_hintForToday;

	private string id1032_coins;

	private string id59_BundleType;

	private string id585_programColored;

	private string id803_inventorySlot3;

	private string id1558_itemToRemoveOnEnd;

	private string id877_skinID;

	private string id574_rowInSpriteSheet;

	private string id530_dropContents;

	private string id1522_stonesLeftOnThisLevel;

	private string id268_Item;

	private string id225_Leaper;

	private string id1531_lighting;

	private string id647_on;

	private string id1778_entries;

	private string id353_JKScoreObjective;

	private string id625_InitialParentTileIndex;

	private string id338_SaveMigrator_1_5;

	private string id826_pinchZoom;

	private string id782_localCoopBaseZoomLevel;

	private string id1204_isOutdoors;

	private string id1597_ForagingLevel;

	private string id230_RockGolem;

	private string id1137_SortMode;

	private string id446_TargetY;

	private string id1083_Item;

	private string id288_CrabPot;

	private string id142_GemBirdType;

	private string id196_Sewer;

	private string id857_isCharging;

	private string id965_usingRandomizedBobber;

	private string id1233_hasBeenKissedToday;

	private string id865_glowRate;

	private string id918_biteChime;

	private string id1033_score;

	private string id411_WeatherDebris;

	private string id1553_questDescription;

	private string id137_InstanceStatics;

	private string id969_combatLevel;

	private string id121_Farm;

	private string id462_type;

	private string id683_cowMilkProduced;

	private string id86_BottomlessEnchantment;

	private string id42_SandDuggy;

	private string id305_StorageFurniture;

	private string id1392_fadeWhenPlayerIsBehind;

	private string id1405_Color3Saturation;

	private string id1212_miniJukeboxTrack;

	private string id537_directionOffset;

	private string id1278_lungeSpeed;

	private string id1774_debuff;

	private string id1054_dayQuestAccepted;

	private string id1340_aimTime;

	private string id735_playerLimit;

	private string id91_DefenseEnchantment;

	private string id502_isPrismatic;

	private string id1682_queenOfSauceRerunWeek;

	private string id1090_SaveablePairOfStringString;

	private string id1468_firstParrotDone;

	private string id725_levelTenFishing;

	private string id680_cheeseMade;

	private string id8_MouseCursor;

	private string id322_GoSomewhereQuest;

	private string id1442_appliedFloor;

	private string id45_BuffManager;

	private string id1618_friendshipReward;

	private string id736_fullscreenResolutionX;

	private string id514_level;

	private string id1195_piecesOfHay;

	private string id1681_Item;

	private string id1587_netVersion;

	private string id1182_Farmer1;

	private string id848_key;

	private string id496_indexInColorSheet;

	private string id1412_overrideWaterColor;

	private string id127_FarmerSpriteLayers;

	private string id821_autoSave;

	private string id479_heldObject;

	private string id1172_GiftsThisWeek;

	private string id1310_stateTimer;

	private string id1811_moveBuildingPermissionMode;

	private string id471_edibility;

	private string id1058_isBigCraftable;

	private string id791_moveUpButton;

	private string id1210_numberOfSpawnedObjectsOnMap;

	private string id1396_Color1Hue;

	private string id1027_fireSpeedLevel;

	private string id250_ChestHitSynchronizer;

	private string id1051_moneyReward;

	private string id1768_destroyMe;

	private string id860_drawOnTop;

	private string id1581_confirmed;

	internal Hashtable CollisionMaskValues
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read434_BigCraftableID()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read435_CHJsonParser()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read436_ContentHashParser()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read437_DistanceToTarget()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read438_DontLoadDefaultSetting()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read439_FurnitureID()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read440_MouseCursor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read441_ArrayOfBoolean()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read442_ArrayOfUnsignedByte()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read443_NetClock()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read444_ArrayOfColor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read445_ArrayOfDouble()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read446_ArrayOfFloat()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read447_ArrayOfGuid()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read448_ArrayOfInt()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read449_ArrayOfInt()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read450_ArrayOfInt()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read451_ArrayOfInt()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read452_ArrayOfLong()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read453_ArrayOfLong()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read454_ArrayOfPoint()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read455_ArrayOfRectangle()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read456_ArrayOfFloat()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read457_ArrayOfString()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read458_ArrayOfString()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read459_ArrayOfString()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read460_ArrayOfVector2()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read461_ArrayOfVector2()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read462_NetVersion()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read463_NotImplicitNetFieldAttribute()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read464_NotNetFieldAttribute()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read465_ObjectID()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read466_AnimalHouse()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read467_LoopingCueManager()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read468_SoundContext()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read469_SoundsHelper()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read470_SandDuggy()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read471_SandDuggyState()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read472_BuffEffects()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read473_BuffManager()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read474_BuildingPaintColor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read475_BuildingPainter()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read476_Barn()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read477_Building()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read478_Coop()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read479_FishPond()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read480_GreenhouseBuilding()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read481_IndoorsType()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read482_JunimoHut()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read483_Mill()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read484_PetBowl()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read485_ShippingBin()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read486_Stable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read487_BundleType()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read488_ChangeType()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read489_Character()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read490_Cat()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read491_Child()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read492_Dog()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read493_Horse()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read494_Junimo()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read495_JunimoHarvester()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read496_Pet()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read497_Raccoon()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read498_TrashBear()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read499_Chunk()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read500_CollisionMask()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read501_AchievementIds()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read502_StatKeys()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read503_Crop()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read504_DebugTimings()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read505_AmethystEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read506_AquamarineEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read507_ArchaeologistEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read508_ArtfulEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read509_AttackEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read510_AutoHookEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read511_AxeEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read512_BaseEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read513_BaseWeaponEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read514_BottomlessEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read515_BugKillerEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read516_CritEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read517_CritPowerEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read518_CrusaderEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read519_DefenseEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read520_DiamondEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read521_EfficientToolEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read522_EmeraldEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read523_FisherEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read524_FishingRodEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read525_GalaxySoulEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read526_GenerousEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read527_HaymakerEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read528_HoeEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read529_JadeEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read530_LightweightEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read531_MagicEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read532_MasterEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read533_MilkPailEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read534_PanEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read535_PickaxeEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read536_PowerfulEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read537_PreservingEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read538_ReachingToolEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read539_RubyEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read540_ShavingEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read541_ShearsEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read542_SlimeGathererEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read543_SlimeSlayerEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read544_SwiftToolEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read545_TopazEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read546_VampiricEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read547_WateringCanEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read548_WeaponSpeedEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read549_Farm()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read550_LightningStrikeEvent()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read551_FarmAnimal()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read552_Farmer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read553_FarmerPair()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read554_FarmerRenderer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read555_FarmerSpriteLayers()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read556_FarmerTeam()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read557_RemoteBuildingPermissions()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read558_SleepAnnounceModes()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read559_Fence()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read560_Friendship()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read561_FriendshipStatus()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read562_GameLocation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read563_InputButton()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read564_InstancedStatic()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read565_InstanceStatics()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read566_ArrayOfBoolean()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read567_Item()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read568_items()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read569_IslandGemBird()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read570_GemBirdType()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read571_Item()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read572_LocalMultiplayer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read573_AbandonedJojaMart()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read574_AdventureGuild()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read575_BathHousePool()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read576_Beach()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read577_BeachNightMarket()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read578_BoatTunnel()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read579_TunnelAnimationState()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read580_BugLand()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read581_BusStop()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read582_Cabin()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read583_Caldera()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read584_Cellar()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read585_Club()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read586_CommunityCenter()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read587_DecoratableLocation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read588_ArrayOfInt()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read589_Desert()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read590_DesertFestival()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read591_RaceState()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read592_FarmCave()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read593_FarmHouse()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read594_FishShop()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read595_Forest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read596_IslandEast()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read597_IslandFarmCave()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read598_IslandFarmHouse()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read599_IslandFieldOffice()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read600_IslandForestLocation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read601_IslandHut()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read602_IslandLocation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read603_IslandNorth()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read604_IslandSecret()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read605_IslandShrine()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read606_IslandSouth()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read607_IslandSouthEast()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read608_IslandSouthEastCave()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read609_IslandWest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read610_IslandWestCave1()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read611_CaveCrystal()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read612_JojaMart()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read613_LibraryMuseum()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read614_ManorHouse()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read615_MermaidHouse()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read616_Mine()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read617_MineInfo()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read618_MineShaft()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read619_Mountain()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read620_MovieTheater()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read621_MovieStates()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read622_Racer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read623_Railroad()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read624_SeedShop()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read625_Sewer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read626_ShopLocation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read627_Submarine()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read628_Summit()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read629_Town()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read630_WizardHouse()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read631_Woods()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read632_MapSeat()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read633_MarriageDialogueReference()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read634_MineChestType()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read635_AngryRoger()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read636_Bat()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read637_BigSlime()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read638_BlueSquid()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read639_Bug()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read640_DinoMonster()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read641_AttackState()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read642_BreathProjectile()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read643_Duggy()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read644_DustSpirit()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read645_DwarvishSentry()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read646_Fly()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read647_Ghost()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read648_GhostVariant()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read649_GreenSlime()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read650_Grub()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read651_HotHead()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read652_LavaLurk()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read653_LavaLurkState()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read654_Leaper()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read655_MetalHead()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read656_Monster()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read657_Mummy()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read658_RockCrab()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read659_RockGolem()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read660_Serpent()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read661_ShadowBrute()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read662_ShadowGirl()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read663_ShadowGuy()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read664_ShadowShaman()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read665_Shooter()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read666_Skeleton()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read667_Spiker()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read668_SquidKid()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read669_MovieInvitation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read670_MovieViewerLockEvent()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read671_Item()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read672_NetLogger()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read673_Item()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read674_NetSynchronizer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read675_BuilderData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read676_ChestHitArgs()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read677_ChestHitSynchronizer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read678_ChestHitTimer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read679_DedicatedServer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read680_DedicatedServerMessageType()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read681_IncomingMessage()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read682_LocationWeather()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read683_Item()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read684_NetCharacterRef()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read685_NetDancePartner()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read686_ArrayOfInt()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read687_ArrayOfFarmer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read688_ArrayOfLong1()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read689_ArrayOfFarmer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read690_NetLocationRef()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read691_NetMutex()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read692_NetNPCRef()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read693_NetPosition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read694_ReadySynchronizer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read695_NetWitnessedLock()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read696_Item()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read697_NewDaySynchronizer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read698_Noise()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read699_NonInstancedStatic()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read700_NPC()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read701_NumberSprite()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read702_Object()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read703_PreserveType()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read704_BedFurniture()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read705_BedType()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read706_Boots()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read707_BreakableContainer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read708_Cask()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read709_Chest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read710_SpecialChestTypes()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read711_Clothing()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read712_ClothesType()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read713_ColoredObject()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read714_CombinedRing()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read715_CrabPot()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read716_DefaultPhoneHandler()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read717_FishTankFurniture()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read718_FishTankCategories()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read719_Furniture()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read720_Hat()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read721_HairDrawType()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read722_IndoorPot()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read723_ItemPedestal()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read724_Mannequin()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read725_MiniJukebox()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read726_PetLicense()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read727_Phone()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read728_RandomizedPlantFurniture()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read729_Ring()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read730_Sign()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read731_SpecialItem()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read732_StorageFurniture()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read733_Trinket()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read734_TV()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read735_Wallpaper()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read736_WoodChipper()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read737_Workbench()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read738_Options()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read739_GamepadModes()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read740_ItemStowingModes()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read741_PriorityQueue()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read742_SchedulePathDescription()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read743_Preconditions()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read744_DebuffingProjectile()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read745_Projectile()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read746_CraftingQuest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read747_DescriptionElement()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read748_FishingQuest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read749_GoSomewhereQuest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read750_HaveBuildingQuest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read751_ItemDeliveryQuest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read752_ItemHarvestQuest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read753_LostItemQuest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read754_ArrayOfDescriptionElement()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read755_ArrayOfDescriptionElement()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read756_Quest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read757_ResourceCollectionQuest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read758_SecretLostItemQuest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read759_SlayMonsterQuest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read760_SocializeQuest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read761_RainDrop()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read762_SaveGame()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read763_SaveFixes()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read764_SaveMigrator_1_3()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read765_SaveMigrator_1_4()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read766_SaveMigrator_1_5()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read767_SaveMigrator_1_6()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read768_LegacyDescriptionElement()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read769_Vector2Reader()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read770_Vector2Serializer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read771_Vector2Writer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read772_ServerPrivacy()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read773_Shed()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read774_SlimeHutch()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read775_CollectObjective()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read776_DeliverObjective()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read777_DonateObjective()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read778_FishObjective()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read779_GiftObjective()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read780_LikeLevels()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read781_JKScoreObjective()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read782_OrderObjective()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read783_ReachMineFloorObjective()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read784_ShipObjective()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read785_SlayObjective()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read786_FriendshipReward()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read787_GemsReward()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read788_MailReward()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read789_MoneyReward()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read790_ObjectReward()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read791_OrderReward()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read792_ResetEventReward()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read793_SpecialOrder()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read794_SpecialOrderStatus()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read795_StackDrawType()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read796_StartMovieEvent()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read797_StartupPreferences()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read798_Stats()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read799_Bush()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read800_CosmeticPlant()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read801_Flooring()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read802_FruitTree()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read803_GiantCrop()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read804_Grass()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read805_HoeDirt()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read806_HoeDirtFertilizerApplyStatus()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read807_LargeTerrainFeature()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read808_ResourceClump()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read809_Tent()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read810_TerrainFeature()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read811_Tree()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read812_TranslationValidator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read813_TranslationValidatorIssue()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read814_TokenParser()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read815_Tool()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read816_Axe()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read817_ErrorTool()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read818_FishingRod()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read819_GenericTool()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read820_Hoe()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read821_Lantern()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read822_MagnifyingGlass()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read823_MeleeWeapon()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read824_MilkPail()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read825_Pan()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read826_Pickaxe()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read827_Raft()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read828_Shears()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read829_Slingshot()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read830_Wand()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read831_WateringCan()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read832_Torch()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read833_BoundingBoxGroup()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read834_Item()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read835_StackTraceHelper()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read836_SynchronizedShopStock()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read837_ToolSpamInputSimulator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read838_Warp()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read839_WeatherDebris()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read840_WorldDate()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read841_MapAreaPositionWithContext()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read842_TapState()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read843_ColorTween()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read844_FloatTween()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read845_QuaternionTween()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read846_StopBehavior()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read847_TweenState()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read848_Vector2Tween()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read849_Vector3Tween()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read850_Vector4Tween()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read851_WalkDirection()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Read852_WeaponControl()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private WeaponControl Read427_WeaponControl(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private WalkDirection Read426_WalkDirection(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector4Tween Read425_Vector4Tween(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3Tween Read423_Vector3Tween(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector2Tween Read421_Vector2Tween(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private TweenState Read419_TweenState(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private StopBehavior Read418_StopBehavior(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private QuaternionTween Read417_QuaternionTween(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FloatTween Read415_FloatTween(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ColorTween Read413_ColorTween(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private TapState Read411_TapState(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MapAreaPositionWithContext Read410_MapAreaPositionWithContext(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private WorldDate Read182_WorldDate(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private WeatherDebris Read409_WeatherDebris(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Rectangle Read14_Rectangle(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Point Read13_Point(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector2 Read15_Vector2(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Warp Read208_Warp(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ToolSpamInputSimulator Read407_ToolSpamInputSimulator(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SynchronizedShopStock Read406_SynchronizedShopStock(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private StackTraceHelper Read405_StackTraceHelper(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private LeftRightClickSpamInputSimulator Read404_Item(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BoundingBoxGroup Read403_BoundingBoxGroup(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Torch Read111_Torch(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Item Read135_Item(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Boots Read32_Boots(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Clothing Read34_Clothing(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Color Read12_Color(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int? Read33_NullableOfInt32(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Hat Read79_Hat(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BaseEnchantment Read78_BaseEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ArtfulEnchantment Read36_ArtfulEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BugKillerEnchantment Read37_BugKillerEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CrusaderEnchantment Read38_CrusaderEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private HaymakerEnchantment Read39_HaymakerEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MagicEnchantment Read40_MagicEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private VampiricEnchantment Read41_VampiricEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private AmethystEnchantment Read62_AmethystEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private AquamarineEnchantment Read63_AquamarineEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DiamondEnchantment Read64_DiamondEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private EmeraldEnchantment Read65_EmeraldEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private JadeEnchantment Read66_JadeEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RubyEnchantment Read67_RubyEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private TopazEnchantment Read68_TopazEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private AttackEnchantment Read69_AttackEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DefenseEnchantment Read70_DefenseEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SlimeSlayerEnchantment Read71_SlimeSlayerEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CritEnchantment Read72_CritEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private WeaponSpeedEnchantment Read73_WeaponSpeedEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CritPowerEnchantment Read74_CritPowerEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private LightweightEnchantment Read75_LightweightEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SlimeGathererEnchantment Read76_SlimeGathererEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private GalaxySoulEnchantment Read77_GalaxySoulEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BaseWeaponEnchantment Read35_BaseWeaponEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ShavingEnchantment Read59_ShavingEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private AxeEnchantment Read42_AxeEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ArchaeologistEnchantment Read49_ArchaeologistEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private GenerousEnchantment Read54_GenerousEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private HoeEnchantment Read43_HoeEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MilkPailEnchantment Read44_MilkPailEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PanEnchantment Read45_PanEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PickaxeEnchantment Read46_PickaxeEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ShearsEnchantment Read47_ShearsEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BottomlessEnchantment Read52_BottomlessEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private WateringCanEnchantment Read48_WateringCanEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private AutoHookEnchantment Read51_AutoHookEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MasterEnchantment Read55_MasterEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PreservingEnchantment Read57_PreservingEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FishingRodEnchantment Read50_FishingRodEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private EfficientToolEnchantment Read53_EfficientToolEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PowerfulEnchantment Read56_PowerfulEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ReachingToolEnchantment Read58_ReachingToolEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SwiftToolEnchantment Read60_SwiftToolEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FisherEnchantment Read61_FisherEnchantment(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BreakableContainer Read80_BreakableContainer(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private StardewValley.Object Read116_Object(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Cask Read81_Cask(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Chest Read82_Chest(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ColoredObject Read83_ColoredObject(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CrabPot Read84_CrabPot(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Fence Read85_Fence(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BedFurniture Read87_BedFurniture(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BedFurniture.BedType Read86_BedType(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RandomizedPlantFurniture Read88_RandomizedPlantFurniture(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FishTankFurniture Read89_FishTankFurniture(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private StorageFurniture Read90_StorageFurniture(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private TV Read91_TV(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Furniture Read92_Furniture(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IndoorPot Read105_IndoorPot(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Bush Read97_Bush(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private HoeDirt Read104_HoeDirt(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Crop Read103_Crop(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ItemPedestal Read106_ItemPedestal(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Mannequin Read107_Mannequin(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MiniJukebox Read108_MiniJukebox(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Phone Read109_Phone(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Sign Read110_Sign(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Trinket Read112_Trinket(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Wallpaper Read113_Wallpaper(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private WoodChipper Read114_WoodChipper(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Workbench Read115_Workbench(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PetLicense Read430_PetLicense(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CombinedRing Read117_CombinedRing(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Ring Read118_Ring(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SpecialItem Read119_SpecialItem(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Axe Read120_Axe(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ErrorTool Read121_ErrorTool(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FishingRod Read122_FishingRod(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private GenericTool Read123_GenericTool(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Hoe Read124_Hoe(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MagnifyingGlass Read125_MagnifyingGlass(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MeleeWeapon Read126_MeleeWeapon(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MilkPail Read127_MilkPail(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Pan Read128_Pan(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Pickaxe Read129_Pickaxe(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Shears Read130_Shears(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Slingshot Read131_Slingshot(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Wand Read132_Wand(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private WateringCan Read133_WateringCan(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Lantern Read431_Lantern(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Raft Read432_Raft(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Tool Read134_Tool(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private TokenParser Read402_TokenParser(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private TranslationValidatorIssue Read401_TranslationValidatorIssue(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private TranslationValidator Read400_TranslationValidator(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Tree Read101_Tree(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private TerrainFeature Read102_TerrainFeature(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Flooring Read93_Flooring(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FruitTree Read94_FruitTree(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CosmeticPlant Read95_CosmeticPlant(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Grass Read96_Grass(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Tent Read433_Tent(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private LargeTerrainFeature Read98_LargeTerrainFeature(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private GiantCrop Read99_GiantCrop(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ResourceClump Read100_ResourceClump(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private HoeDirtFertilizerApplyStatus Read399_HoeDirtFertilizerApplyStatus(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Stats Read181_Stats(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private uint? Read180_NullableOfUInt32(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private StartupPreferences Read398_StartupPreferences(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Options Read363_Options(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private InputButton Read312_InputButton(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Keys Read311_Keys(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ServerPrivacy Read362_ServerPrivacy(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Options.GamepadModes Read361_GamepadModes(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Options.ItemStowingModes Read360_ItemStowingModes(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private StartMovieEvent Read397_StartMovieEvent(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Character Read185_Character(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Gender Read28_Gender(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FarmAnimal Read29_FarmAnimal(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Farmer Read184_Farmer(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool? Read30_NullableOfBoolean(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private AbigailGame.JOTPKProgress Read183_JOTPKProgress(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Quest Read179_Quest(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CraftingQuest Read31_CraftingQuest(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FishingQuest Read137_FishingQuest(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DescriptionElement Read136_DescriptionElement(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object Read1_Object(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private StackDrawType Read396_StackDrawType(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SpecialOrderStatus Read395_SpecialOrderStatus(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private GiftObjective.LikeLevels Read394_LikeLevels(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SaveFixes Read381_SaveFixes(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private TutorialShopLocation Read379_TutorialShopLocation(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private TutorialType Read378_TutorialType(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SaveablePair<int, long> Read377_SaveablePairOfInt32Int64(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SaveablePair<FarmerPair, Friendship> Read376_Item(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Friendship Read309_Friendship(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FriendshipStatus Read308_FriendshipStatus(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FarmerPair Read280_FarmerPair(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SaveablePair<string, Item[]> Read375_Item(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NetLeaderboardsEntry Read373_NetLeaderboardsEntry(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SaveablePair<int, MineInfo> Read372_SaveablePairOfInt32MineInfo(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MineInfo Read321_MineInfo(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SaveablePair<long, Options> Read371_SaveablePairOfInt64Options(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SaveablePair<string, int> Read370_SaveablePairOfStringInt32(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SaveablePair<string, string> Read369_SaveablePairOfStringString(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SaveablePair<string, BuilderData> Read368_Item(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BuilderData Read335_BuilderData(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private GameLocation Read258_GameLocation(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NPC Read196_NPC(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SchedulePathDescription Read186_SchedulePathDescription(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private AngryRoger Read145_AngryRoger(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Bat Read146_Bat(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BigSlime Read147_BigSlime(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BlueSquid Read148_BlueSquid(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Bug Read149_Bug(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DinoMonster Read151_DinoMonster(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DinoMonster.BreathProjectile Read150_BreathProjectile(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Duggy Read152_Duggy(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DustSpirit Read153_DustSpirit(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DwarvishSentry Read154_DwarvishSentry(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Fly Read155_Fly(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Ghost Read156_Ghost(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private GreenSlime Read157_GreenSlime(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Grub Read158_Grub(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private HotHead Read160_HotHead(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MetalHead Read159_MetalHead(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private LavaLurk Read161_LavaLurk(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Leaper Read162_Leaper(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Mummy Read163_Mummy(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RockCrab Read164_RockCrab(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RockGolem Read165_RockGolem(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Serpent Read167_Serpent(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 Read166_Vector3(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ShadowBrute Read168_ShadowBrute(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ShadowGirl Read169_ShadowGirl(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ShadowGuy Read170_ShadowGuy(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ShadowShaman Read171_ShadowShaman(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Shooter Read172_Shooter(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Skeleton Read173_Skeleton(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Spiker Read174_Spiker(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SquidKid Read175_SquidKid(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Monster Read176_Monster(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Cat Read188_Cat(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Dog Read190_Dog(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Pet Read187_Pet(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Child Read189_Child(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Horse Read191_Horse(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Junimo Read192_Junimo(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private JunimoHarvester Read193_JunimoHarvester(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private TrashBear Read194_TrashBear(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Raccoon Read195_Raccoon(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Building Read268_Building(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BuildingPaintColor Read26_BuildingPaintColor(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Barn Read259_Barn(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Coop Read260_Coop(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FishPond Read261_FishPond(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private GreenhouseBuilding Read262_GreenhouseBuilding(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private JunimoHut Read263_JunimoHut(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Mill Read264_Mill(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PetBowl Read265_PetBowl(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ShippingBin Read266_ShippingBin(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Stable Read267_Stable(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private AbandonedJojaMart Read197_AbandonedJojaMart(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private AdventureGuild Read198_AdventureGuild(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private AnimalHouse Read199_AnimalHouse(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BathHousePool Read200_BathHousePool(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Beach Read201_Beach(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BeachNightMarket Read202_BeachNightMarket(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BoatTunnel Read204_BoatTunnel(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BoatTunnel.TunnelAnimationState Read203_TunnelAnimationState(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BugLand Read205_BugLand(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BusStop Read206_BusStop(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Cabin Read211_Cabin(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private long? Read210_NullableOfInt64(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FarmHouse Read209_FarmHouse(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IslandFarmHouse Read228_IslandFarmHouse(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Shed Read251_Shed(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SlimeHutch Read252_SlimeHutch(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DecoratableLocation Read207_DecoratableLocation(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Caldera Read214_Caldera(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IslandGemBird Read212_IslandGemBird(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IslandEast Read226_IslandEast(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IslandShrine Read233_IslandShrine(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IslandForestLocation Read225_IslandForestLocation(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IslandFarmCave Read227_IslandFarmCave(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IslandFieldOffice Read229_IslandFieldOffice(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IslandHut Read230_IslandHut(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IslandNorth Read231_IslandNorth(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IslandSecret Read232_IslandSecret(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IslandSouth Read234_IslandSouth(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IslandSouthEast Read235_IslandSouthEast(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IslandSouthEastCave Read236_IslandSouthEastCave(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IslandWest Read237_IslandWest(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SandDuggy Read22_SandDuggy(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IslandWestCave1 Read238_IslandWestCave1(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IslandLocation Read213_IslandLocation(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Cellar Read215_Cellar(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Club Read216_Club(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CommunityCenter Read217_CommunityCenter(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DesertFestival Read219_DesertFestival(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Desert Read218_Desert(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Farm Read220_Farm(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FarmCave Read221_FarmCave(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FishShop Read223_FishShop(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SeedShop Read249_SeedShop(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ShopLocation Read222_ShopLocation(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Forest Read224_Forest(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private JojaMart Read239_JojaMart(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private LibraryMuseum Read240_LibraryMuseum(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ManorHouse Read241_ManorHouse(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MermaidHouse Read242_MermaidHouse(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Mine Read243_Mine(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MineShaft Read245_MineShaft(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Random Read244_Random(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Mountain Read246_Mountain(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MovieTheater Read247_MovieTheater(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Railroad Read248_Railroad(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Sewer Read250_Sewer(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Submarine Read253_Submarine(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Summit Read254_Summit(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Town Read255_Town(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private WizardHouse Read256_WizardHouse(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Woods Read257_Woods(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private TankFish.FishType Read359_FishType(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Hat.HairDrawType Read358_HairDrawType(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FishTankFurniture.FishTankCategories Read357_FishTankCategories(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Clothing.ClothesType Read355_ClothesType(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Chest.SpecialChestTypes Read354_SpecialChestTypes(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private StardewValley.Object.PreserveType Read353_PreserveType(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DedicatedServerMessageType Read340_DedicatedServerMessageType(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private LavaLurk.State Read331_State(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Ghost.GhostVariant Read330_GhostVariant(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DinoMonster.AttackState Read329_AttackState(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MineChestType Read328_MineChestType(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private VolcanoDungeon.TileNeighbors Read325_TileNeighbors(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MovieTheater.MovieStates Read322_MovieStates(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DesertFestival.RaceState Read319_RaceState(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private LocalizedContentManager.LanguageCode Read317_LanguageCode(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private LightSource.LightContext Read316_LightContext(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IslandGemBird.GemBirdType Read315_GemBirdType(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private HouseRenovation.AnimationType Read310_AnimationType(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FarmerTeam.SleepAnnounceModes Read307_SleepAnnounceModes(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FarmerTeam.RemoteBuildingPermissions Read306_RemoteBuildingPermissions(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PlayerStatusList.DisplayMode Read303_DisplayMode(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PlayerStatusList.SortMode Read302_SortMode(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MovieInvitation Read301_MovieInvitation(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SpecialOrder Read300_SpecialOrder(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private OrderReward Read299_OrderReward(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FriendshipReward Read293_FriendshipReward(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private GemsReward Read294_GemsReward(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MailReward Read295_MailReward(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MoneyReward Read296_MoneyReward(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ObjectReward Read297_ObjectReward(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ResetEventReward Read298_ResetEventReward(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private OrderObjective Read292_OrderObjective(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CollectObjective Read283_CollectObjective(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DeliverObjective Read284_DeliverObjective(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DonateObjective Read285_DonateObjective(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FishObjective Read286_FishObjective(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private GiftObjective Read287_GiftObjective(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private JKScoreObjective Read288_JKScoreObjective(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ReachMineFloorObjective Read289_ReachMineFloorObjective(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ShipObjective Read290_ShipObjective(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SlayObjective Read291_SlayObjective(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FarmerRenderer.FarmerSpriteLayers Read282_FarmerSpriteLayers(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CollisionMask Read275_CollisionMask(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ChangeType Read271_ChangeType(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BundleType Read270_BundleType(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IndoorsType Read269_IndoorsType(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SandDuggy.State Read23_State(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SoundContext Read20_SoundContext(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MouseCursor Read9_MouseCursor(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DistanceToTarget Read5_DistanceToTarget(string s)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BigCraftableID Read2_BigCraftableID(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CHJsonParser Read3_CHJsonParser(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ContentHashParser Read4_ContentHashParser(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DontLoadDefaultSetting Read7_DontLoadDefaultSetting(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NotImplicitNetFieldAttribute Read16_NotImplicitNetFieldAttribute(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NotNetFieldAttribute Read17_NotNetFieldAttribute(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private InstancedStatic Read313_InstancedStatic(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private InstanceStatics Read314_InstanceStatics(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NonInstancedStatic Read351_NonInstancedStatic(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Attribute Read6_Attribute(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FurnitureID Read8_FurnitureID(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NetVersion Read10_NetVersion(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NetClock Read11_NetClock(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ObjectID Read18_ObjectID(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private LoopingCueManager Read19_LoopingCueManager(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SoundsHelper Read21_SoundsHelper(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BuffEffects Read24_BuffEffects(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BuffManager Read25_BuffManager(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BuildingPainter Read27_BuildingPainter(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private GoSomewhereQuest Read138_GoSomewhereQuest(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private HaveBuildingQuest Read139_HaveBuildingQuest(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ItemDeliveryQuest Read140_ItemDeliveryQuest(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ItemHarvestQuest Read141_ItemHarvestQuest(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private LostItemQuest Read142_LostItemQuest(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ResourceCollectionQuest Read143_ResourceCollectionQuest(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SecretLostItemQuest Read144_SecretLostItemQuest(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SlayMonsterQuest Read177_SlayMonsterQuest(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SocializeQuest Read178_SocializeQuest(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NetPosition Read273_NetPosition(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NetPausableField<Vector2, NetVector2, NetVector2> Read272_Item(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Chunk Read274_Chunk(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private AchievementIds Read276_AchievementIds(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private StatKeys Read277_StatKeys(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DebugTimings Read278_DebugTimings(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Farm.LightningStrikeEvent Read279_LightningStrikeEvent(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FarmerRenderer Read281_FarmerRenderer(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PlayerStatusList Read304_PlayerStatusList(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FarmerTeam Read305_FarmerTeam(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private LocalMultiplayer Read318_LocalMultiplayer(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IslandWestCave1.CaveCrystal Read320_CaveCrystal(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Racer Read324_Racer(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector2? Read323_NullableOfVector2(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MapSeat Read326_MapSeat(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MarriageDialogueReference Read327_MarriageDialogueReference(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MovieViewerLockEvent Read332_MovieViewerLockEvent(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NetLogger Read333_NetLogger(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NewDaySynchronizer Read428_NewDaySynchronizer(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NetSynchronizer Read334_NetSynchronizer(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ChestHitArgs Read336_ChestHitArgs(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ChestHitSynchronizer Read337_ChestHitSynchronizer(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ChestHitTimer Read338_ChestHitTimer(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DedicatedServer Read339_DedicatedServer(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IncomingMessage Read341_IncomingMessage(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private LocationWeather Read342_LocationWeather(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NetCharacterRef Read343_NetCharacterRef(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NetDancePartner Read344_NetDancePartner(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NetLocationRef Read345_NetLocationRef(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NetMutex Read346_NetMutex(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NetNPCRef Read347_NetNPCRef(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ReadySynchronizer Read348_ReadySynchronizer(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NetWitnessedLock Read349_NetWitnessedLock(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Noise Read350_Noise(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NumberSprite Read352_NumberSprite(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DefaultPhoneHandler Read356_DefaultPhoneHandler(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PriorityQueue Read364_PriorityQueue(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Preconditions Read365_Preconditions(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DebuffingProjectile Read429_DebuffingProjectile(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Projectile Read366_Projectile(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RainDrop Read367_RainDrop(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NetLeaderboards Read374_NetLeaderboards(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SaveGame Read380_SaveGame(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SaveMigrator_1_3 Read382_SaveMigrator_1_3(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SaveMigrator_1_4 Read383_SaveMigrator_1_4(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SaveMigrator_1_5 Read384_SaveMigrator_1_5(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SaveMigrator_1_6 Read385_SaveMigrator_1_6(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SaveMigrator_1_6.LegacyDescriptionElement Read386_LegacyDescriptionElement(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector2Reader Read389_Vector2Reader(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private XmlSerializationReader Read388_XmlSerializationReader(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector2Writer Read393_Vector2Writer(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private XmlSerializationWriter Read392_XmlSerializationWriter(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private XmlSerializationGeneratedCode Read387_XmlSerializationGeneratedCode(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector2Serializer Read391_Vector2Serializer(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private XmlSerializer Read390_XmlSerializer(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private WaterTiles.WaterTileData Read408_WaterTileData(bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Tween<Color> Read412_TweenOfColor(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Tween<float> Read414_TweenOfSingle(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Tween<Quaternion> Read416_TweenOfQuaternion(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Tween<Vector2> Read420_TweenOfVector2(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Tween<Vector3> Read422_TweenOfVector3(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Tween<Vector4> Read424_TweenOfVector4(bool isNullable, bool checkType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InitCallbacks()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InitIDs()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public XmlSerializationReader1()
	{
	}
}
