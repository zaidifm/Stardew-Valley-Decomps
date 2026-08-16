using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StardewValley.Delegates;
using StardewValley.Internal;
using StardewValley.Logging;

namespace StardewValley;

public static class DebugCommands
{
	public static class DefaultHandlers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GrowWildTrees(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Emote(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void EventTestSpecific(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void EventTest(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetAllQuests(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Movie(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MovieSchedule(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Shop(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ExportShops(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Dating(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ClearActiveDialogueEvents(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Buff(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ClearBuffs(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PauseTime(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "fbf" })]
		public static void FrameByFrame(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "fbp", "fill", "fillbp" })]
		public static void FillBackpack(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Bobber(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "sl" })]
		public static void ShiftToolbarLeft(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "sr" })]
		public static void ShiftToolbarRight(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CharacterInfo(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DoesItemExist(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SpecialItem(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AnimalInfo(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ClearChildren(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CreateSplash(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Pregnant(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SpreadSeeds(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SpreadDirt(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveFurniture(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MakeEx(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DarkTalisman(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ConventionMode(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void FarmMap(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ClearMuseum(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Clone(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "zl" })]
		public static void ZoomLevel(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "us" })]
		public static void UiScale(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DeleteArch(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Save(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "removeLargeTf" })]
		public static void RemoveLargeTerrainFeature(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Test(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void FenceDecay(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "sb" })]
		public static void ShowTextAboveHead(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Gamepad(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Slimecraft(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "kms" })]
		public static void KillMonsterStat(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveAnimals(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void FixAnimals(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DisplaceAnimals(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "sdkInfo" })]
		public static void SteamInfo(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Achieve(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ResetAchievements(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Divorce(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void BefriendAnimals(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PetToFarm(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void BefriendPets(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Version(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "sdlv" })]
		public static void SdlVersion(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "ns" })]
		public static void NoSave(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "rfh" })]
		public static void ReadyForHarvest(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void BeachBridge(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Dp(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "fo" })]
		public static void FrameOffset(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Horse(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Owl(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Pole(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveQuest(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CompleteQuest(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetPreferredPet(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ChangePet(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ClearCharacters(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Cat(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Dog(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Quest(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DeliveryQuest(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CollectQuest(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SlayQuest(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Quests(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ClearQuests(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "fb" })]
		public static void FillBin(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Gold(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ClearFarm(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetupFarm(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveBuildings(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Build(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ForceBuild(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "fab" })]
		public static void FinishAllBuilds(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LocalInfo(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "al" })]
		public static void AmbientLight(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ResetMines(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "db" })]
		public static void SpeakTo(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SkullKey(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void TownKey(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Specials(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SkullGear(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ClearSpecials(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Tv(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "sn" })]
		public static void SecretNote(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Child2(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "kid" })]
		public static void Child(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void KillAll(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ResetWorldState(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void KillAllHorses(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DatePlayer(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void EngagePlayer(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MarryPlayer(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Marry(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Engaged(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ClearLightGlows(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "wp" })]
		public static void Wallpaper(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ClearFurniture(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "ff" })]
		public static void Furniture(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SpawnCoopsAndBarns(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetupFishPondFarm(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Grass(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetupBigFarm(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "hu", "house" })]
		public static void HouseUpgrade(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "thu", "thishouse" })]
		public static void ThisHouseUpgrade(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "ci" })]
		public static void Clear(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "w" })]
		public static void Wall(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Floor(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Sprinkle(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ClearMail(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void BroadcastMailbox(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "mft" })]
		public static void MailForTomorrow(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AllMail(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AllMailRead(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ShowMail(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "where" })]
		public static void WhereIs(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "whereItem" })]
		public static void WhereIsItem(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "pm" })]
		public static void PanMode(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "is" })]
		public static void InputSim(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Hurry(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MorePollen(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void FillWithObject(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SpawnWeeds(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void BusDriveBack(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void BusDriveOff(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CompleteJoja(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CompleteCc(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Break(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void WhereOre(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AllBundles(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void JunimoGoodbye(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Bundle(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "lu" })]
		public static void Lookup(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CcLoadCutscene(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CcLoad(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Plaque(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void JunimoStar(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "j", "aj" })]
		public static void AddJunimo(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ResetJunimoNotes(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "jn" })]
		public static void JunimoNote(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void WaterColor(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void FestivalScore(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddOtherFarmer(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PlayMusic(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Jump(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Toss(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Rain(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GreenRain(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "sf" })]
		public static void SetFrame(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "ee" })]
		public static void EndEvent(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Language(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "rte" })]
		public static void RunTestEvent(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "qb" })]
		public static void QiBoard(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "ob" })]
		public static void OrdersBoard(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ReturnedDonations(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "cso" })]
		public static void CompleteSpecialOrders(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SpecialOrder(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void BoatJourney(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Minigame(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Event(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "ebi" })]
		public static void EventById(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void EventScript(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "sfe" })]
		public static void SetFarmEvent(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void TestWedding(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Festival(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "ps" })]
		public static void PlaySound(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LogSounds(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "poali" })]
		public static void PrintOpenAlInfo(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Crafting(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Cooking(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Experience(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ShowExperience(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Profession(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ClearFishCaught(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "caughtFish" })]
		public static void FishCaught(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "r" })]
		public static void ResetForPlayerEntry(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Fish(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GrowAnimals(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PauseAnimals(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UnpauseAnimals(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "removetf" })]
		public static void RemoveTerrainFeatures(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MushroomTrees(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void TrashCan(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void FruitTrees(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Train(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DebrisWeather(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Speed(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DayUpdate(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void FarmerDayUpdate(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MuseumLoot(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void NewMuseumLoot(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CreateDebris(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveDebris(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveDirt(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DyeAll(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DyeShirt(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DyePants(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "cmenu", "customize" })]
		public static void CustomizeMenu(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CopyOutfit(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SkinColor(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Hat(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Pants(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void HairStyle(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void HairColor(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Shirt(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "m", "mv" })]
		public static void MusicVolume(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveObjects(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ListLights(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveLights(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "i" })]
		public static void Item(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "iq" })]
		public static void ItemQuery(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "gq" })]
		public static void GameQuery(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Tokens(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DyeMenu(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Tailor(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Forge(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ListTags(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void QualifiedId(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Dye(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetIndex(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "f", "fin" })]
		public static void FuzzyItemNamed(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "in" })]
		public static void ItemNamed(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Achievement(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Heal(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Die(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Energize(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Exhaust(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Warp(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "wh" })]
		public static void WarpHome(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Money(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CatchAllFish(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ActivateCalicoStatue(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Perfection(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Walnut(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Gem(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "removeNpc" })]
		public static void KillNpc(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "dap" })]
		public static void DaysPlayed(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void FriendAll(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "friend" })]
		public static void Friendship(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetStat(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetStat(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "eventSeen" })]
		public static void SeenEvent(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SeenMail(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CookingRecipe(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "craftingRecipe" })]
		public static void AddCraftingRecipe(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UpgradeHouse(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void StopRafting(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Time(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddMinute(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddHour(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Water(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GrowCrops(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "c", "cm" })]
		public static void CanMove(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Backpack(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Question(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Year(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Day(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Season(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "dialogue" })]
		public static void AddDialogue(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Speech(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LoadDialogue(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Wedding(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GameMode(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Volcano(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MineLevel(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MineInfo(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Viewport(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MakeInedible(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "watm" })]
		public static void WarpAnimalToMe(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "wctm" })]
		public static void WarpCharacterToMe(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "wc" })]
		public static void WarpCharacter(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "wtp" })]
		public static void WarpToPlayer(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "wtc" })]
		public static void WarpToCharacter(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "wct" })]
		public static void WarpCharacterTo(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "ws" })]
		public static void WarpShop(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void FacePlayer(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Refuel(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Lantern(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GrowGrass(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddAllCrafting(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Animal(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MoveBuilding(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Fishing(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "fd", "face" })]
		public static void FaceDirection(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Note(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void NetHost(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void NetJoin(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ToggleNetCompression(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LevelUp(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Darts(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MineGame(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Crane(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "trlt" })]
		public static void TailorRecipeListTool(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "apt" })]
		public static void AnimationPreviewTool(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CreateDino(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "pta" })]
		public static void PerformTitleAction(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Action(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void BroadcastMail(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Phone(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Renovate(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Crib(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void TestNut(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ShuffleBundles(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Split(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "bsm" })]
		public static void SkinBuilding(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "bpm" })]
		public static void PaintBuilding(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "md" })]
		public static void MineDifficulty(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "scd" })]
		public static void SkullCaveDifficulty(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "tls" })]
		public static void ToggleLightingScale(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void FixWeapons(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "plsf" })]
		public static void PrintLatestSaveFix(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "pdb" })]
		public static void PrintGemBirds(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "ppp" })]
		public static void PrintPlayerPos(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ShowPlurals(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void HoldItem(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "rm" })]
		public static void RunMacro(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void InviteMovie(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Monster(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "shaft" })]
		public static void Ladder(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void NetLog(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void NetClear(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void NetDump(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "tto" })]
		public static void ToggleTimingOverlay(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LogBandwidth(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LogWallAndFloorWarnings(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ChangeWallet(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SeparateWallets(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MergeWallets(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "nd", "newDay", "s" })]
		public static void Sleep(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "gm", "inv" })]
		public static void Invincible(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ValidateNetFields(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "flm" })]
		public static void FilterLoadMenu(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void WorldMapPosition(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Search(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ArtifactSpots(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void XEdge(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LogFile(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ToggleCheats(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void WarpNext(int index)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void WarpAll(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void MineNext(int level)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MinesAll(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void VolcanoNext(int level)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VolcanoAll(string[] command, IGameLogger log)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "lc" })]
		public static void LinkedChallenge(string[] command, IGameLogger log)
		{
		}
	}

	private static readonly Dictionary<string, DebugCommandHandlerDelegate> Handlers;

	private static readonly Dictionary<string, string> Aliases;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DebugCommands()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryHandle(string[] command, IGameLogger log = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<string> SearchCommandNames(string search, bool displayAliases = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void LogArgError(IGameLogger log, string[] command, string error)
	{
	}
}
