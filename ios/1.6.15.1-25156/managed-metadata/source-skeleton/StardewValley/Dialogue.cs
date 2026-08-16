using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley;

public class Dialogue
{
	public delegate bool onAnswerQuestion(int whichResponse);

	public const string dialogueHappy = "$h";

	public const string dialogueSad = "$s";

	public const string dialogueUnique = "$u";

	public const string dialogueNeutral = "$neutral";

	public const string dialogueLove = "$l";

	public const string dialogueAngry = "$a";

	public const string dialogueEnd = "$e";

	public const char dialogueCommandPrefix = '$';

	public const string dialogueBreak = "$b";

	public const string dialogueBreakDelimited = "#$b#";

	public const string multipleDialogueDelineator = "||";

	public const string dialogueKill = "$k";

	public const string dialogueChance = "$c";

	public const string dialogueDependingOnWorldState = "$d";

	public const string dialogueEvent = "$v";

	public const string dialogueQuickResponse = "$y";

	public const string dialoguePrerequisite = "$p";

	public const string dialogueSingle = "$1";

	public const string dialogueGameStateQuery = "$query";

	public const string dialogueGenderSwitch_startBlock = "${";

	public const string dialogueGenderSwitch_endBlock = "}$";

	public const string dialogueRunAction = "$action";

	public const string dialogueStartConversationTopic = "$t";

	public const string dialogueQuestion = "$q";

	public const string dialogueResponse = "$r";

	public const string breakSpecialCharacter = "{";

	public const string playerNameSpecialCharacter = "@";

	public const char genderDialogueSplitCharacter = '^';

	public const char genderDialogueSplitCharacter2 = '¦';

	public const string quickResponseDelineator = "*";

	public const string randomAdjectiveSpecialCharacter = "%adj";

	public const string randomNounSpecialCharacter = "%noun";

	public const string randomPlaceSpecialCharacter = "%place";

	public const string spouseSpecialCharacter = "%spouse";

	public const string randomNameSpecialCharacter = "%name";

	public const string firstNameLettersSpecialCharacter = "%firstnameletter";

	public const string timeSpecialCharacter = "%time";

	public const string bandNameSpecialCharacter = "%band";

	public const string bookNameSpecialCharacter = "%book";

	public const string petSpecialCharacter = "%pet";

	public const string farmNameSpecialCharacter = "%farm";

	public const string favoriteThingSpecialCharacter = "%favorite";

	public const string eventForkSpecialCharacter = "%fork";

	public const string yearSpecialCharacter = "%year";

	public const string kid1specialCharacter = "%kid1";

	public const string kid2SpecialCharacter = "%kid2";

	public const string revealTasteCharacter = "%revealtaste";

	public const string seasonCharacter = "%season";

	public const string dontfacefarmer = "%noturn";

	public const char noPortraitPrefix = '%';

	public const string FallbackDialogueForErrorKey = "Strings\\Characters:FallbackDialogueForError";

	public static readonly string[] percentTokens;

	private static bool nameArraysTranslated;

	public static string[] adjectives;

	public static string[] nouns;

	public static string[] verbs;

	public static string[] positional;

	public static string[] places;

	public static string[] colors;

	public List<DialogueLine> dialogues;

	public HashSet<int> indexesWithoutPortrait;

	private List<NPCDialogueResponse> playerResponses;

	private List<string> quickResponses;

	private bool isLastDialogueInteractive;

	private bool quickResponse;

	public bool isCurrentStringContinuedOnNextScreen;

	private bool finishedLastDialogue;

	public bool showPortrait;

	public bool removeOnNextMove;

	public bool dontFaceFarmer;

	public string temporaryDialogueKey;

	public int currentDialogueIndex;

	private string currentEmotion;

	public NPC speaker;

	public onAnswerQuestion answerQuestionBehavior;

	public Texture2D overridePortrait;

	public Action onFinish;

	public readonly string TranslationKey;

	public string CurrentEmotion
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

	public bool CurrentEmotionSetExplicitly
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TranslateArraysOfStrings()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dialogue(NPC speaker, string translationKey, string dialogueText)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dialogue(NPC speaker, string translationKey, bool isGendered = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dialogue(Dialogue other)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dialogue TryGetDialogue(NPC speaker, string translationKey)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dialogue FromTranslation(NPC speaker, string translationKey)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dialogue FromTranslation(NPC speaker, string translationKey, object sub1)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dialogue FromTranslation(NPC speaker, string translationKey, object sub1, object sub2)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dialogue FromTranslation(NPC speaker, string translationKey, object sub1, object sub2, object sub3)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dialogue FromTranslation(NPC speaker, string translationKey, params object[] substitutions)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dialogue GetFallbackForError(NPC speaker)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetFallbackTextForError()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getRandomVerb()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getRandomAdjective()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getRandomNoun()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getRandomPositional()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getPortraitIndex()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void parseDialogueString(string masterString, string translationKey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void prepareDialogueForDisplay()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void prepareCurrentDialogueForDisplay()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string getCurrentDialogue()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isItemGrabDialogue()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isOnFinalDialogue()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isDialogueFinished()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ReplacePlayerEnteredStrings(string str)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string checkForSpecialCharacters(string str)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string applyGenderSwitch(string str, bool altTokenOnly = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string applyGenderSwitch(Gender gender, string str, bool altTokenOnly = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string applyGenderSwitchBlocks(Gender gender, string str)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void applyAndSkipPlainSideEffects()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string randomName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ReplaceBadRandomName(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string exitCurrentDialogue()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkForSpecialDialogueAttributes()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkEmotions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<NPCDialogueResponse> getNPCResponseOptions()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Response[] getResponseOptions()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isCurrentDialogueAQuestion()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool chooseResponse(Response response)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void performDialogueResponseExtraArgument(Farmer farmer, string argument)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void convertToDwarvish()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string convertToDwarvish(string str)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
