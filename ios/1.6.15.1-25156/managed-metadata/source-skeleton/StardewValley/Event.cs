using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.Delegates;
using StardewValley.Internal;
using StardewValley.Menus;
using xTile.Dimensions;

namespace StardewValley;

public class Event
{
	public static class DefaultCommands
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void IgnoreEventTileOffset(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Move(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Action(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Speak(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void BeginSimultaneousCommand(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void EndSimultaneousCommand(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MineDeath(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void HospitalDeath(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ShowItemsLost(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void End(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LocationSpecificCommand(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Unskippable(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Skippable(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetSkipActions(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Emote(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void StopMusic(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PlayPetSound(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PlaySound(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void StopSound(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void TossConcession(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Pause(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PrecisePause(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ResetVariable(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void FaceDirection(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Warp(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void WarpFarmers(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Speed(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void StopAdvancedMoves(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DoAction(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveTile(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void TextAboveHead(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ShowFrame(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void FarmerAnimation(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void IgnoreMovementAnimation(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Animate(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void StopAnimation(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ChangeLocation(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Halt(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Message(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddCookingRecipe(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ItemAboveHead(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddCraftingRecipe(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void HostMail(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Mail(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MailToday(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Shake(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void TemporaryAnimatedSprite(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void TemporarySprite(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveTemporarySprites(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Null(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SpecificTemporarySprite(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PlayMusic(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MakeInvisible(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddObject(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddBigProp(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddFloorProp(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddProp(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveObject(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Glow(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void StopGlowing(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddQuest(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveQuest(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddSpecialOrder(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveSpecialOrder(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddItem(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AwardFestivalPrize(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AttachCharacterToTempSprite(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Fork(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SwitchEvent(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GlobalFade(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GlobalFadeToClear(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Cutscene(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void WaitForTempSprite(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Cave(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UpdateMinigame(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void StartJittering(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Money(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void StopJittering(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddLantern(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RustyKey(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Swimming(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void StopSwimming(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void TutorialMenu(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AnimalNaming(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SplitSpeak(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CatQuestion(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AmbientLight(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void BgColor(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ElliottBookTalk(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveItem(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Friendship(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetRunning(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ExtendSourceRect(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void WaitForOtherPlayers(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RequestMovieEnd(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RestoreStashedItem(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AdvancedMove(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void StopRunning(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Eyes(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OtherNames(new string[] { "mailReceived" })]
		public static void AddMailReceived(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddWorldState(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Fade(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ChangeMapTile(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ChangeSprite(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void WaitForAllStationary(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ProceedPosition(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ChangePortrait(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ChangeYSourceRectOffset(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ChangeName(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void TranslateName(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ReplaceWithClone(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PlayFramesAhead(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ShowKissFrame(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddTemporaryActor(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ChangeToTemporaryMap(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PositionOffset(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Question(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void QuickQuestion(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DrawOffset(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void HideShadow(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AnimateHeight(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Jump(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void FarmerEat(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SpriteText(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void IgnoreCollisions(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ScreenFlash(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GrandpaCandles(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GrandpaEvaluation2(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GrandpaEvaluation(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LoadActors(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PlayerControl(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveSprite(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Viewport(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void BroadcastEvent(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddConversationTopic(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Dump(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void EventSeen(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void QuestionAnswered(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GainSkill(Event @event, string[] args, EventContext context)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MoveToSoup(Event @event, string[] args, EventContext context)
		{
		}
	}

	protected static readonly Dictionary<string, EventCommandDelegate> Commands;

	protected static readonly Dictionary<string, string> CommandAliases;

	protected static readonly HashSet<string> CommandNames;

	protected static readonly Dictionary<string, EventPreconditionDelegate> Preconditions;

	private static readonly Dictionary<string, string> PreconditionAliases;

	private const float timeBetweenSpeech = 500f;

	public const string festivalTextureName = "Maps\\Festivals";

	private string festivalDataAssetName;

	public string id;

	public string fromAssetName;

	public bool isFestival;

	public bool isWedding;

	public bool isMemory;

	public bool skippable;

	public string[] actionsOnSkip;

	public bool skipped;

	public bool forked;

	public bool eventSwitched;

	internal bool notifyWhenDone;

	internal string notifyLocationName;

	internal byte notifyLocationIsStructure;

	private readonly LocalizedContentManager festivalContent;

	public string[] eventCommands;

	public int currentCommand;

	private Dictionary<string, Vector3> actorPositionsAfterMove;

	private float timeAccumulator;

	private Vector3 viewportTarget;

	private Color previousAmbientLight;

	private HashSet<long> festivalWinners;

	private GameLocation temporaryLocation;

	private Dictionary<string, string> festivalData;

	private Texture2D _festivalTexture;

	private bool drawTool;

	private string hostMessageKey;

	private int previousFacingDirection;

	private int previousAnswerChoice;

	private bool startSecretSantaAfterDialogue;

	private List<Farmer> iceFishWinners;

	protected static LocalizedContentManager FestivalReadContentLoader;

	protected bool _playerControlSequence;

	protected bool _repeatingLocationSpecificCommand;

	[NonInstancedStatic]
	public static HashSet<string> invalidFestivals;

	public List<NPC> actors;

	public List<Object> props;

	public List<Prop> festivalProps;

	public List<Farmer> farmerActors;

	public Dictionary<string, Dictionary<ISalable, ItemStockInformation>> festivalShops;

	public List<NPCController> npcControllers;

	internal NPC festivalHost;

	public NPC secretSantaRecipient;

	public NPC mySecretSanta;

	public TemporaryAnimatedSpriteList underwaterSprites;

	public TemporaryAnimatedSpriteList aboveMapSprites;

	public IDictionary<string, List<ICue>> CustomSounds;

	public ICustomEventScript currentCustomEventScript;

	public bool simultaneousCommand;

	public int farmerAddedSpeed;

	public int int_useMeForAnything;

	public int int_useMeForAnything2;

	public float float_useMeForAnything;

	public string playerControlSequenceID;

	public string spriteTextToDraw;

	public bool showActiveObject;

	public bool continueAfterMove;

	public bool specialEventVariable1;

	public bool specialEventVariable2;

	public bool showGroundObjects;

	public bool doingSecretSanta;

	public bool showWorldCharacters;

	public bool ignoreObjectCollisions;

	public Point playerControlTargetTile;

	public List<Vector2> characterWalkLocations;

	public Vector2 eventPositionTileOffset;

	public int festivalTimer;

	public int grangeScore;

	public bool grangeJudged;

	public bool ignoreTileOffsets;

	private Stopwatch stopWatch;

	public LocationRequest exitLocation;

	public Action onEventFinished;

	public bool markEventSeen;

	private bool eventFinished;

	private bool gotPet;

	public string FestivalName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool playerControlSequence
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public Farmer farmer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Texture2D festivalTexture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int CurrentCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterCommand(string name, EventCommandDelegate action)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterCommandAlias(string alias, string commandName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryResolveCommandName(string name, out string actualName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterPrecondition(string name, EventPreconditionDelegate action)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterPreconditionAlias(string alias, string preconditionName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void SetupEventCommandsIfNeeded()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetPreconditionHandler(string key, out EventPreconditionDelegate handler)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckPrecondition(GameLocation location, string eventId, string precondition)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetEventCommandHandler(string key, out EventCommandDelegate handler)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void tryEventCommand(GameLocation location, GameTime time, string[] args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Event(string eventString, Farmer farmerActor = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Event(string eventString, string fromAssetName, string eventID, Farmer farmerActor = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Event()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ResetToNativeZoom()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~Event()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnNewDay()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool tryToLoadFestivalData(string festival, out string assetName, out Dictionary<string, string> data, out string locationName, out int startTime, out int endTime)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool tryToLoadFestival(string festival, out Event ev)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetFestivalDialogueForYear(NPC npc, string key, out Dialogue dialogue)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetFestivalDataForYear(string key, out string data, out string actualKey)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetFestivalDataForYear(string key, out string data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setExitLocation(Warp warp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setExitLocation(string location, int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void endBehaviors(GameLocation location = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void endBehaviors(string[] args, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void exitEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void notifyDone()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetDialogueIfNecessary(NPC n)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void incrementCommandAfterFade()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void cleanup()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void changeLocation(string locationName, int x, int y, Action onComplete = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogCommandError(string[] args, string error, bool willSkip = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogCommandErrorAndSkip(string[] args, string error, bool hideError = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogErrorAndHalt(string error, Exception e = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogErrorAndHalt(Exception e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool LogPreconditionError(GameLocation location, string eventId, string[] args, string error)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(GameLocation location, GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void InitializeEvent(GameLocation location, GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool UpdateBeforeNextCommand(GameLocation location, GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void CheckForNextCommand(GameLocation location, GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetCurrentCommand()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReplaceCurrentCommand(string command)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReplaceAllCommands(params string[] commands)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsertNextCommand(string command)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TrackSound(ICue cue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopTrackedSound(string cueId, bool immediate)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopTrackedSounds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isTileWalkedOn(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void populateWalkLocationsList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NPC getActorByName(string name, bool legacyReplaceUnderscores = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NPC getActorByName(string name, out bool isOptionalNpc, bool legacyReplaceUnderscores = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addActor(string name, int x, int y, int facingDirection, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Farmer GetFarmerActor(int farmerNumber)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsCurrentFarmerActorId(string actor)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsCurrentFarmerActorId(int farmerNumber)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFarmerActorId(string actor, out int farmerNumber)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Character getCharacterByName(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 getPositionAfterMove(Character c, int xMove, int yMove, int facingDirection)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void trySpecialSetUp(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setUpCharacters(string description, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void beakerSmashEndFunction(int extraInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eggSmashEndFunction(int extraInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void balloonInSky(int extraInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void marcelloBalloonLand(int extraInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void samPreOllie(int extraInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void samOllie(int extraInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void samGrind(int extraInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void samDropOff(int extraInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void samGround(int extraInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void catchFootball(int extraInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void footballLand(int extraInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void parrotSplat(int extraInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Vector2 OffsetPosition(Vector2 original)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Vector2 OffsetTile(Vector2 original)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float OffsetPositionX(float original)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float OffsetPositionY(float original)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int OffsetTileX(int original)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int OffsetTileY(int original)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addSpecificTemporarySprite(string key, GameLocation location, string[] args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Microsoft.Xna.Framework.Rectangle skipBounds()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveGamePadButton(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveMouseClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickSkip()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void skipEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void receiveActionPress(int xTile, int yTile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void startSecretSantaEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void festivalUpdate(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setUpSecretSantaCommands()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawFarmers(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ShouldHideCharacter(NPC n)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawUnderWater(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawAfterMap(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndPlayerControlSequence()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPlayerControlSequenceEnd(string id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setUpPlayerControlSequence(string id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool canMoveAfterDialogue()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void forceFestivalContinue()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string[] SplitPreconditions(string rawScript)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string[] ParseCommands(string rawScript, Farmer player = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isSpecificFestival(string festivalId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setUpFestivalMainEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void judgeGrange()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lewisDoneJudgingGrange()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void interpretGrangeResults()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void initiateGrangeJudging()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void answerDialogueQuestion(NPC who, string answerKey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addItemToGrangeDisplay(Item i, int position, bool force)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool onGrangeChange(Item i, int position, Item old, StorageContainer container, bool onRemoval)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool onMobileGrangeChange(Item i, int position, Item old, ItemGrabMenu container, bool onRemoval)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool canPlayerUseTool()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void removeFestivalProps(Microsoft.Xna.Framework.Rectangle rect)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForSpecialCharacterIconAtThisTile(Vector2 tileLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void forceEndFestival(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool checkForCollision(Microsoft.Xna.Framework.Rectangle position, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryStartEndFestivalDialogue(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void answerDialogue(string questionKey, int answerChoice)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hostActionChooseCave(Farmer who, BinaryReader reader)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hostActionNamePet(Farmer who, BinaryReader reader)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void namePet(string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void onCloseSantaInventory(Item i, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void chooseSecretSantaGift(Item i, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void perfectFishing()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void caughtFish(string itemId, int size, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void readFortune()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fadeClearAndviewportUnfreeze()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void betStarTokens(int value, int price, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void buyStarTokens(int value, int price, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void clickToAddItemToLuauSoup(Item i, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setUpAdvancedMove(string[] args, NPCController.endBehavior endBehavior = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsItemMayorShorts(Item i)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void addItemToLuauSoup(Item i, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void governorTaste()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eggHuntWinner()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void iceFishingWinner()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void iceFishingWinnerMP()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void popBalloons(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GenerateLightSourceId(string suffix)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
