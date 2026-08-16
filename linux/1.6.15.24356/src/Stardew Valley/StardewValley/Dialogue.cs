using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Extensions;
using StardewValley.TokenizableStrings;
using StardewValley.Triggers;

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

	public static readonly string[] percentTokens = new string[18]
	{
		"%adj", "%noun", "%place", "%spouse", "%name", "%firstnameletter", "%time", "%band", "%book", "%pet",
		"%farm", "%favorite", "%fork", "%year", "%kid1", "%kid2", "%revealtaste", "%season"
	};

	private static bool nameArraysTranslated = false;

	public static string[] adjectives = new string[20]
	{
		"Purple", "Gooey", "Chalky", "Green", "Plush", "Chunky", "Gigantic", "Greasy", "Gloomy", "Practical",
		"Lanky", "Dopey", "Crusty", "Fantastic", "Rubbery", "Silly", "Courageous", "Reasonable", "Lonely", "Bitter"
	};

	public static string[] nouns = new string[23]
	{
		"Dragon", "Buffet", "Biscuit", "Robot", "Planet", "Pepper", "Tomb", "Hyena", "Lip", "Quail",
		"Cheese", "Disaster", "Raincoat", "Shoe", "Castle", "Elf", "Pump", "Chip", "Wig", "Mermaid",
		"Drumstick", "Puppet", "Submarine"
	};

	public static string[] verbs = new string[13]
	{
		"ran", "danced", "spoke", "galloped", "ate", "floated", "stood", "flowed", "smelled", "swam",
		"grilled", "cracked", "melted"
	};

	public static string[] positional = new string[13]
	{
		"atop", "near", "with", "alongside", "away from", "too close to", "dangerously close to", "far, far away from", "uncomfortably close to", "way above the",
		"miles below", "on a different planet from", "in a different century than"
	};

	public static string[] places = new string[12]
	{
		"Castle Village", "Basket Town", "Pine Mesa City", "Point Drake", "Minister Valley", "Grampleton", "Zuzu City", "a small island off the coast", "Fort Josa", "Chestervale",
		"Fern Islands", "Tanker Grove"
	};

	public static string[] colors = new string[16]
	{
		"/crimson", "/green", "/tan", "/purple", "/deep blue", "/neon pink", "/pale/yellow", "/chocolate/brown", "/sky/blue", "/bubblegum/pink",
		"/blood/red", "/bright/orange", "/aquamarine", "/silvery", "/glimmering/gold", "/rainbow"
	};

	public List<DialogueLine> dialogues = new List<DialogueLine>();

	public HashSet<int> indexesWithoutPortrait = new HashSet<int>();

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
		get
		{
			return currentEmotion ?? "$neutral";
		}
		set
		{
			currentEmotion = value;
		}
	}

	public bool CurrentEmotionSetExplicitly => currentEmotion != null;

	public Farmer farmer
	{
		get
		{
			if (Game1.CurrentEvent != null)
			{
				return Game1.CurrentEvent.farmer;
			}
			return Game1.player;
		}
	}

	private static void TranslateArraysOfStrings()
	{
		colors = new string[16]
		{
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.795"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.796"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.797"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.798"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.799"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.800"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.801"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.802"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.803"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.804"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.805"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.806"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.807"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.808"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.809"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.810")
		};
		adjectives = new string[20]
		{
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.679"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.680"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.681"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.682"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.683"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.684"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.685"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.686"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.687"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.688"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.689"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.690"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.691"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.692"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.693"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.694"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.695"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.696"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.697"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.698")
		};
		nouns = new string[23]
		{
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.699"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.700"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.701"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.702"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.703"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.704"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.705"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.706"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.707"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.708"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.709"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.710"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.711"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.712"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.713"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.714"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.715"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.716"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.717"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.718"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.719"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.720"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.721")
		};
		verbs = new string[13]
		{
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.722"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.723"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.724"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.725"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.726"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.727"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.728"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.729"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.730"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.731"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.732"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.733"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.734")
		};
		positional = new string[13]
		{
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.735"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.736"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.737"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.738"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.739"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.740"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.741"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.742"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.743"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.744"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.745"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.746"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.747")
		};
		places = new string[12]
		{
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.748"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.749"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.750"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.751"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.752"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.753"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.754"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.755"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.756"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.757"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.758"),
			Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.759")
		};
		nameArraysTranslated = true;
	}

	public Dialogue(NPC speaker, string translationKey, string dialogueText)
	{
		if (!nameArraysTranslated)
		{
			TranslateArraysOfStrings();
		}
		this.speaker = speaker;
		TranslationKey = translationKey;
		try
		{
			parseDialogueString(dialogueText, translationKey);
			checkForSpecialDialogueAttributes();
		}
		catch (Exception exception)
		{
			Game1.log.Error($"Failed parsing dialogue string for NPC {speaker?.Name} (key: {translationKey}, text: {dialogueText}).", exception);
			parseDialogueString(GetFallbackTextForError(), "Strings\\Characters:FallbackDialogueForError");
			checkForSpecialDialogueAttributes();
		}
	}

	public Dialogue(NPC speaker, string translationKey, bool isGendered = false)
		: this(speaker, translationKey, isGendered ? Game1.LoadStringByGender(speaker.Gender, translationKey) : Game1.content.LoadString(translationKey))
	{
	}

	public Dialogue(Dialogue other)
	{
		foreach (DialogueLine dialogue in other.dialogues)
		{
			dialogues.Add(new DialogueLine(dialogue.Text, dialogue.SideEffects));
		}
		indexesWithoutPortrait = new HashSet<int>(other.indexesWithoutPortrait);
		if (other.playerResponses != null)
		{
			playerResponses = new List<NPCDialogueResponse>();
			foreach (NPCDialogueResponse playerResponse in other.playerResponses)
			{
				playerResponses.Add(new NPCDialogueResponse(playerResponse));
			}
		}
		if (other.quickResponses != null)
		{
			quickResponses = new List<string>(other.quickResponses);
		}
		isLastDialogueInteractive = other.isLastDialogueInteractive;
		quickResponse = other.quickResponse;
		isCurrentStringContinuedOnNextScreen = other.isCurrentStringContinuedOnNextScreen;
		finishedLastDialogue = other.finishedLastDialogue;
		showPortrait = other.showPortrait;
		removeOnNextMove = other.removeOnNextMove;
		dontFaceFarmer = other.dontFaceFarmer;
		temporaryDialogueKey = other.temporaryDialogueKey;
		currentDialogueIndex = other.currentDialogueIndex;
		currentEmotion = other.currentEmotion;
		speaker = other.speaker;
		answerQuestionBehavior = other.answerQuestionBehavior;
		overridePortrait = other.overridePortrait;
		onFinish = other.onFinish;
		TranslationKey = other.TranslationKey;
	}

	public static Dialogue TryGetDialogue(NPC speaker, string translationKey)
	{
		string text = Game1.content.LoadStringReturnNullIfNotFound(translationKey);
		if (text == null)
		{
			return null;
		}
		return new Dialogue(speaker, translationKey, text);
	}

	public static Dialogue FromTranslation(NPC speaker, string translationKey)
	{
		return new Dialogue(speaker, translationKey);
	}

	public static Dialogue FromTranslation(NPC speaker, string translationKey, object sub1)
	{
		return new Dialogue(speaker, translationKey, Game1.content.LoadString(translationKey, sub1));
	}

	public static Dialogue FromTranslation(NPC speaker, string translationKey, object sub1, object sub2)
	{
		return new Dialogue(speaker, translationKey, Game1.content.LoadString(translationKey, sub1, sub2));
	}

	public static Dialogue FromTranslation(NPC speaker, string translationKey, object sub1, object sub2, object sub3)
	{
		return new Dialogue(speaker, translationKey, Game1.content.LoadString(translationKey, sub1, sub2, sub3));
	}

	public static Dialogue FromTranslation(NPC speaker, string translationKey, params object[] substitutions)
	{
		return new Dialogue(speaker, translationKey, Game1.content.LoadString(translationKey, substitutions));
	}

	public static Dialogue GetFallbackForError(NPC speaker)
	{
		return TryGetDialogue(speaker, "Strings\\Characters:FallbackDialogueForError") ?? new Dialogue(speaker, "Strings\\Characters:FallbackDialogueForError", "...");
	}

	public static string GetFallbackTextForError()
	{
		return Game1.content.LoadStringReturnNullIfNotFound("Strings\\Characters:FallbackDialogueForError") ?? "...";
	}

	public static string getRandomVerb()
	{
		if (!nameArraysTranslated)
		{
			TranslateArraysOfStrings();
		}
		return Game1.random.Choose(verbs);
	}

	public static string getRandomAdjective()
	{
		if (!nameArraysTranslated)
		{
			TranslateArraysOfStrings();
		}
		return Game1.random.Choose(adjectives);
	}

	public static string getRandomNoun()
	{
		if (!nameArraysTranslated)
		{
			TranslateArraysOfStrings();
		}
		return Game1.random.Choose(nouns);
	}

	public static string getRandomPositional()
	{
		if (!nameArraysTranslated)
		{
			TranslateArraysOfStrings();
		}
		return Game1.random.Choose(positional);
	}

	public int getPortraitIndex()
	{
		if (speaker != null && Game1.isGreenRain && speaker.Name.Equals("Demetrius") && Game1.year == 1)
		{
			return 7;
		}
		switch (CurrentEmotion)
		{
		case "$neutral":
			return 0;
		case "$h":
			return 1;
		case "$s":
			return 2;
		case "$u":
			return 3;
		case "$l":
			return 4;
		case "$a":
			return 5;
		default:
		{
			if (!int.TryParse(CurrentEmotion.Substring(1), out var result))
			{
				return 0;
			}
			return result;
		}
		}
	}

	protected virtual void parseDialogueString(string masterString, string translationKey)
	{
		masterString = TokenParser.ParseText(masterString ?? "...");
		string[] array = masterString.Split("||");
		if (array.Length > 1)
		{
			masterString = array[Game1.stats.DaysPlayed / 7 % array.Length];
		}
		playerResponses?.Clear();
		string[] array2 = masterString.Split('#');
		for (int i = 0; i < array2.Length; i++)
		{
			string text = array2[i];
			if (text.Length < 2)
			{
				continue;
			}
			text = (array2[i] = checkForSpecialCharacters(text));
			bool flag = false;
			string text2;
			string commandArgs;
			if (text.StartsWith('$'))
			{
				string[] array3 = ArgUtility.SplitBySpace(text, 2);
				text2 = array3[0];
				commandArgs = ArgUtility.Get(array3, 1);
				flag = true;
				if (text2 == null)
				{
					goto IL_08a2;
				}
				int length = text2.Length;
				if (length != 2)
				{
					if (length != 6)
					{
						if (length != 7 || !(text2 == "$action"))
						{
							goto IL_08a2;
						}
						dialogues.Add(new DialogueLine("", delegate
						{
							if (!TriggerActionManager.TryRunAction(commandArgs, out var error, out var exception))
							{
								error = $"Failed to parse {"$action"} token for {translationKey ?? speaker?.Name ?? ("\"" + masterString + "\"")}: {error}.";
								if (exception == null)
								{
									Game1.log.Warn(error);
								}
								else
								{
									Game1.log.Error(error, exception);
								}
							}
						}));
					}
					else
					{
						if (!(text2 == "$query"))
						{
							goto IL_08a2;
						}
						string queryString = commandArgs;
						string[] array4 = ArgUtility.Get(masterString.Split('#', 2), 1)?.Split('|') ?? LegacyShims.EmptyArray<string>();
						array2 = (GameStateQuery.CheckConditions(queryString) ? array4[0].Split('#') : ArgUtility.Get(array4, 1, array4[0]).Split('#'));
						i--;
					}
				}
				else
				{
					switch (text2[1])
					{
					case 'e':
						break;
					case 'b':
						goto IL_01a0;
					case 'k':
						goto IL_01b6;
					case '1':
						goto IL_01cc;
					case 'c':
						goto IL_01e2;
					case 't':
						goto IL_01f8;
					case 'q':
						goto IL_020e;
					case 'r':
						goto IL_0224;
					case 'p':
						goto IL_023a;
					case 'd':
						goto IL_0250;
					case 'y':
						goto IL_0266;
					default:
						goto IL_08a2;
					}
					if (!(text2 == "$e"))
					{
						goto IL_08a2;
					}
				}
			}
			goto IL_08a5;
			IL_01b6:
			if (!(text2 == "$k"))
			{
				goto IL_08a2;
			}
			goto IL_08a5;
			IL_08a2:
			flag = false;
			goto IL_08a5;
			IL_020e:
			if (!(text2 == "$q"))
			{
				goto IL_08a2;
			}
			if (dialogues.Count > 0)
			{
				dialogues[dialogues.Count - 1].Text += "{";
			}
			string[] array5 = ArgUtility.SplitBySpace(commandArgs);
			string[] array6 = array5[0].Split('/');
			bool flag2 = false;
			for (int num = 0; num < array6.Length; num++)
			{
				if (farmer.DialogueQuestionsAnswered.Contains(array6[num]))
				{
					flag2 = true;
					break;
				}
			}
			if (flag2 && array6[0] != "-1")
			{
				if (!array5[1].Equals("null"))
				{
					array2 = array2.Take(i).Concat(speaker.Dialogue[array5[1]].Split('#')).ToArray();
					i--;
				}
			}
			else
			{
				isLastDialogueInteractive = true;
			}
			goto IL_08a5;
			IL_0224:
			if (!(text2 == "$r"))
			{
				goto IL_08a2;
			}
			string[] array7 = ArgUtility.SplitBySpace(commandArgs);
			if (playerResponses == null)
			{
				playerResponses = new List<NPCDialogueResponse>();
			}
			isLastDialogueInteractive = true;
			playerResponses.Add(new NPCDialogueResponse(array7[0], Convert.ToInt32(array7[1]), array7[2], array2[i + 1]));
			i++;
			goto IL_08a5;
			IL_01cc:
			if (text2 == "$1")
			{
				string text3 = ArgUtility.SplitBySpaceAndGet(commandArgs, 0);
				if (text3 != null)
				{
					if (farmer.mailReceived.Contains(text3))
					{
						i += 3;
						if (i < array2.Length)
						{
							array2[i] = checkForSpecialCharacters(array2[i]);
							dialogues.Add(new DialogueLine(array2[i]));
						}
					}
					else
					{
						array2[i + 1] = checkForSpecialCharacters(array2[i + 1]);
						dialogues.Add(new DialogueLine(text3 + "}" + array2[i + 1]));
						i = 99999;
					}
					goto IL_08a5;
				}
			}
			goto IL_08a2;
			IL_0266:
			if (!(text2 == "$y"))
			{
				goto IL_08a2;
			}
			quickResponse = true;
			isLastDialogueInteractive = true;
			if (quickResponses == null)
			{
				quickResponses = new List<string>();
			}
			if (playerResponses == null)
			{
				playerResponses = new List<NPCDialogueResponse>();
			}
			string text4 = text.Substring(text.IndexOf('\'') + 1);
			text4 = text4.Substring(0, text4.Length - 1);
			string[] array8 = text4.Split('_');
			dialogues.Add(new DialogueLine(array8[0]));
			for (int num2 = 1; num2 < array8.Length; num2 += 2)
			{
				string text5 = array8[num2];
				string text6 = array8[num2 + 1];
				if (text6.Contains("*"))
				{
					text6 = text6.Replace("**", "<<<<asterisk>>>>").Replace("*", "#$b#").Replace("<<<<asterisk>>>>", "*");
				}
				playerResponses.Add(new NPCDialogueResponse(null, -1, "quickResponse" + num2, Game1.parseText(text5)));
				quickResponses.Add(text6);
			}
			goto IL_08a5;
			IL_023a:
			if (!(text2 == "$p"))
			{
				goto IL_08a2;
			}
			string[] array9 = ArgUtility.SplitBySpace(commandArgs);
			string[] array10 = array2[i + 1].Split('|');
			bool flag3 = false;
			for (int num3 = 0; num3 < array9.Length; num3++)
			{
				if (farmer.DialogueQuestionsAnswered.Contains(array9[num3]))
				{
					flag3 = true;
					break;
				}
			}
			if (flag3)
			{
				array2 = array10[0].Split('#');
				i = -1;
			}
			else
			{
				array2[i + 1] = array2[i + 1].Split('|').Last();
			}
			goto IL_08a5;
			IL_01a0:
			if (!(text2 == "$b"))
			{
				goto IL_08a2;
			}
			if (dialogues.Count > 0)
			{
				dialogues[dialogues.Count - 1].Text += "{";
			}
			goto IL_08a5;
			IL_01f8:
			if (!(text2 == "$t"))
			{
				goto IL_08a2;
			}
			dialogues.Add(new DialogueLine("", delegate
			{
				string[] array12 = ArgUtility.SplitBySpace(commandArgs);
				if (!ArgUtility.TryGet(array12, 0, out var value, out var error, allowBlank: false, "string topicId") || !ArgUtility.TryGetOptionalInt(array12, 1, out var value2, out error, 4, "int daysDuration"))
				{
					Game1.log.Warn($"Failed to parse {"$t"} token for {translationKey ?? speaker?.Name ?? ("\"" + masterString + "\"")}: {error}.");
				}
				else
				{
					Game1.player.activeDialogueEvents.TryAdd(value, value2);
				}
			}));
			goto IL_08a5;
			IL_08a5:
			if (!flag)
			{
				text = applyGenderSwitch(text);
				dialogues.Add(new DialogueLine(text));
			}
			continue;
			IL_0250:
			if (!(text2 == "$d"))
			{
				goto IL_08a2;
			}
			string[] array11 = ArgUtility.SplitBySpace(commandArgs);
			string text7 = masterString.Substring(masterString.IndexOf('#') + 1);
			bool flag4 = false;
			switch (array11[0].ToLower())
			{
			case "joja":
				flag4 = Game1.isLocationAccessible("JojaMart");
				break;
			case "cc":
			case "communitycenter":
				flag4 = Game1.isLocationAccessible("CommunityCenter");
				break;
			case "bus":
				flag4 = Game1.MasterPlayer.mailReceived.Contains("ccVault");
				break;
			case "kent":
				flag4 = Game1.year >= 2;
				break;
			}
			char separator = (text7.Contains('|') ? '|' : '#');
			array2 = ((!flag4) ? text7.Split(separator)[1].Split('#') : text7.Split(separator)[0].Split('#'));
			i--;
			goto IL_08a5;
			IL_01e2:
			if (text2 == "$c")
			{
				string text8 = ArgUtility.SplitBySpaceAndGet(commandArgs, 0);
				if (text8 != null)
				{
					double chance = Convert.ToDouble(text8);
					if (!Game1.random.NextBool(chance))
					{
						i++;
					}
					else
					{
						dialogues.Add(new DialogueLine(array2[i + 1]));
						i += 3;
					}
					goto IL_08a5;
				}
			}
			goto IL_08a2;
		}
	}

	public virtual void prepareDialogueForDisplay()
	{
		if (dialogues.Count > 0 && speaker != null && speaker.shouldWearIslandAttire.Value && Game1.player.friendshipData.TryGetValue(speaker.Name, out var value) && value.IsDivorced() && CurrentEmotion == "$u")
		{
			CurrentEmotion = "$neutral";
		}
	}

	public virtual void prepareCurrentDialogueForDisplay()
	{
		applyAndSkipPlainSideEffects();
		if (currentDialogueIndex >= dialogues.Count)
		{
			return;
		}
		string text = dialogues[currentDialogueIndex].Text;
		text = Utility.ParseGiftReveals(text);
		showPortrait = true;
		if (text.StartsWith("$v"))
		{
			string[] array = ArgUtility.SplitBySpace(text);
			string eventId = array[1];
			bool checkPreconditions = true;
			bool checkSeen = true;
			if (array.Length > 2 && array[2] == "false")
			{
				checkPreconditions = false;
			}
			if (array.Length > 3 && array[3] == "false")
			{
				checkSeen = false;
			}
			if (Game1.PlayEvent(eventId, checkPreconditions, checkSeen))
			{
				dialogues.Clear();
				exitCurrentDialogue();
				return;
			}
			exitCurrentDialogue();
			if (!isDialogueFinished())
			{
				prepareCurrentDialogueForDisplay();
			}
			return;
		}
		if (text.Contains('}'))
		{
			farmer.mailReceived.Add(text.Split('}')[0]);
			text = text.Substring(text.IndexOf("}") + 1);
			text = text.Replace("$k", "");
		}
		if (text.Contains("$k"))
		{
			text = text.Replace("$k", "");
			dialogues.RemoveRange(currentDialogueIndex + 1, dialogues.Count - 1 - currentDialogueIndex);
			if (text.Length < 2)
			{
				finishedLastDialogue = true;
			}
		}
		if (text.StartsWith('%'))
		{
			bool flag = false;
			string[] array2 = percentTokens;
			foreach (string value in array2)
			{
				if (text.StartsWith(value))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				indexesWithoutPortrait.Add(currentDialogueIndex);
				showPortrait = false;
				text = text.Substring(1);
			}
		}
		else if (indexesWithoutPortrait.Contains(currentDialogueIndex))
		{
			showPortrait = false;
		}
		text = ReplacePlayerEnteredStrings(text);
		if (text.Contains('['))
		{
			int num = -1;
			do
			{
				num = text.IndexOf('[', Math.Max(num, 0));
				if (num < 0)
				{
					continue;
				}
				int num2 = text.IndexOf(']', num);
				if (num2 < 0)
				{
					break;
				}
				string[] array3 = ArgUtility.SplitBySpace(text.Substring(num + 1, num2 - num - 1));
				bool flag2 = false;
				string[] array2 = array3;
				for (int i = 0; i < array2.Length; i++)
				{
					if (ItemRegistry.GetData(array2[i]) == null)
					{
						flag2 = true;
						break;
					}
				}
				if (flag2)
				{
					num++;
					continue;
				}
				Item item = ItemRegistry.Create(Game1.random.Choose(array3));
				if (item != null)
				{
					if (farmer.addItemToInventoryBool(item, makeActiveObject: true))
					{
						farmer.showCarrying();
					}
					else
					{
						farmer.addItemByMenuIfNecessary(item, null, forceQueue: true);
					}
				}
				text = text.Remove(num, num2 - num + 1);
			}
			while (num >= 0 && num < text.Length);
		}
		text = text.Replace("%time", Game1.getTimeOfDayString(Game1.timeOfDay));
		bool? flag3 = speaker?.SpeaksDwarvish();
		if (flag3.HasValue && flag3 == true && !farmer.canUnderstandDwarves)
		{
			text = convertToDwarvish(text);
		}
		dialogues[currentDialogueIndex].Text = text;
	}

	public virtual string getCurrentDialogue()
	{
		if (currentDialogueIndex >= dialogues.Count || finishedLastDialogue)
		{
			return "";
		}
		if (dialogues.Count <= 0)
		{
			return Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.792");
		}
		return dialogues[currentDialogueIndex].Text;
	}

	public bool isItemGrabDialogue()
	{
		if (currentDialogueIndex < dialogues.Count)
		{
			return dialogues[currentDialogueIndex].Text.Contains('[');
		}
		return false;
	}

	public bool isOnFinalDialogue()
	{
		for (int i = currentDialogueIndex + 1; i < dialogues.Count; i++)
		{
			if (dialogues[i].HasText)
			{
				return false;
			}
		}
		return true;
	}

	public bool isDialogueFinished()
	{
		return finishedLastDialogue;
	}

	public string ReplacePlayerEnteredStrings(string str)
	{
		if (string.IsNullOrEmpty(str))
		{
			return str;
		}
		string text = Utility.FilterUserName(farmer.Name);
		str = str.Replace("@", text);
		if (str.Contains('%'))
		{
			str = str.Replace("%firstnameletter", text.Substring(0, Math.Max(0, text.Length / 2)));
			if (str.Contains("%spouse"))
			{
				if (farmer.spouse != null)
				{
					string displayName = NPC.GetDisplayName(farmer.spouse);
					str = str.Replace("%spouse", displayName);
				}
				else
				{
					long? spouse = farmer.team.GetSpouse(farmer.UniqueMultiplayerID);
					if (spouse.HasValue)
					{
						Farmer player = Game1.GetPlayer(spouse.Value);
						str = str.Replace("%spouse", player.Name);
					}
				}
			}
			string newValue = Utility.FilterUserName(farmer.farmName.Value);
			str = str.Replace("%farm", newValue);
			string newValue2 = Utility.FilterUserName(farmer.favoriteThing.Value);
			str = str.Replace("%favorite", newValue2);
			int numberOfChildren = farmer.getNumberOfChildren();
			str = str.Replace("%kid1", (numberOfChildren > 0) ? farmer.getChildren()[0].displayName : Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.793"));
			str = str.Replace("%kid2", (numberOfChildren > 1) ? farmer.getChildren()[1].displayName : Game1.content.LoadString("Strings\\StringsFromCSFiles:Dialogue.cs.794"));
			str = str.Replace("%pet", farmer.getPetDisplayName());
		}
		return str;
	}

	public string checkForSpecialCharacters(string str)
	{
		str = applyGenderSwitch(str, altTokenOnly: true);
		if (str.Contains('%'))
		{
			str = str.Replace("%adj", Game1.random.Choose(adjectives).ToLower());
			if (str.Contains("%noun"))
			{
				str = ((LocalizedContentManager.CurrentLanguageCode == LocalizedContentManager.LanguageCode.de) ? (str.Substring(0, str.IndexOf("%noun") + "%noun".Length).Replace("%noun", Game1.random.Choose(nouns)) + str.Substring(str.IndexOf("%noun") + "%noun".Length).Replace("%noun", Game1.random.Choose(nouns))) : (str.Substring(0, str.IndexOf("%noun") + "%noun".Length).Replace("%noun", Game1.random.Choose(nouns).ToLower()) + str.Substring(str.IndexOf("%noun") + "%noun".Length).Replace("%noun", Game1.random.Choose(nouns).ToLower())));
			}
			str = str.Replace("%place", Game1.random.Choose(places));
			str = str.Replace("%name", randomName());
			str = str.Replace("%band", Game1.samBandName);
			if (str.Contains("%book"))
			{
				str = str.Replace("%book", Game1.elliottBookName);
			}
			str = str.Replace("%year", Game1.year.ToString() ?? "");
			str = str.Replace("%season", Game1.CurrentSeasonDisplayName);
			if (str.Contains("%fork"))
			{
				str = str.Replace("%fork", "");
				if (Game1.currentLocation.currentEvent != null)
				{
					Game1.currentLocation.currentEvent.specialEventVariable1 = true;
				}
			}
		}
		return str;
	}

	public string applyGenderSwitch(string str, bool altTokenOnly = false)
	{
		return applyGenderSwitch(farmer.Gender, str, altTokenOnly);
	}

	public static string applyGenderSwitch(Gender gender, string str, bool altTokenOnly = false)
	{
		str = applyGenderSwitchBlocks(gender, str);
		int num = ((!altTokenOnly) ? str.IndexOf('^') : (-1));
		if (num == -1)
		{
			num = str.IndexOf('¦');
		}
		if (num != -1)
		{
			str = ((gender == Gender.Male) ? str.Substring(0, num) : str.Substring(num + 1));
		}
		return str;
	}

	public static string applyGenderSwitchBlocks(Gender gender, string str)
	{
		int startIndex = 0;
		while (true)
		{
			int num = str.IndexOf("${", startIndex, StringComparison.Ordinal);
			if (num == -1)
			{
				return str;
			}
			int num2 = str.IndexOf("}$", num, StringComparison.Ordinal);
			if (num2 == -1)
			{
				break;
			}
			string text = str.Substring(num + 2, num2 - num - 2);
			string[] array = (text.Contains('¦') ? text.Split('¦') : text.Split('^'));
			string text2 = gender switch
			{
				Gender.Male => array[0], 
				Gender.Female => ArgUtility.Get(array, 1, array[0]), 
				_ => ArgUtility.Get(array, 2, array[0]), 
			};
			str = str.Substring(0, num) + text2 + str.Substring(num2 + "}$".Length);
			startIndex = num + text2.Length;
		}
		return str;
	}

	public void applyAndSkipPlainSideEffects()
	{
		while (currentDialogueIndex < dialogues.Count)
		{
			DialogueLine dialogueLine = dialogues[currentDialogueIndex];
			if (!dialogueLine.HasText)
			{
				dialogueLine.SideEffects?.Invoke();
				currentDialogueIndex++;
				continue;
			}
			break;
		}
	}

	public static string randomName()
	{
		switch (LocalizedContentManager.CurrentLanguageCode)
		{
		case LocalizedContentManager.LanguageCode.ja:
		{
			string[] options5 = new string[38]
			{
				"ローゼン", "ミルド", "ココ", "ナミ", "こころ", "サルコ", "ハンゾー", "クッキー", "ココナツ", "せん",
				"ハル", "ラン", "オサム", "ヨシ", "ソラ", "ホシ", "まこと", "マサ", "ナナ", "リオ",
				"リン", "フジ", "うどん", "ミント", "さくら", "ボンボン", "レオ", "モリ", "コーヒー", "ミルク",
				"マロン", "クルミ", "サムライ", "カミ", "ゴロ", "マル", "チビ", "ユキダマ"
			};
			return Game1.random.Choose(options5);
		}
		case LocalizedContentManager.LanguageCode.zh:
		{
			string[] options3 = new string[183]
			{
				"雨果", "蛋挞", "小百合", "毛毛", "小雨", "小溪", "精灵", "安琪儿", "小糕", "玫瑰",
				"小黄", "晓雨", "阿江", "铃铛", "马琪", "果粒", "郁金香", "小黑", "雨露", "小江",
				"灵力", "萝拉", "豆豆", "小莲", "斑点", "小雾", "阿川", "丽丹", "玛雅", "阿豆",
				"花花", "琉璃", "滴答", "阿山", "丹麦", "梅西", "橙子", "花儿", "晓璃", "小夕",
				"山大", "咪咪", "卡米", "红豆", "花朵", "洋洋", "太阳", "小岩", "汪汪", "玛利亚",
				"小菜", "花瓣", "阳阳", "小夏", "石头", "阿狗", "邱洁", "苹果", "梨花", "小希",
				"天天", "浪子", "阿猫", "艾薇儿", "雪梨", "桃花", "阿喜", "云朵", "风儿", "狮子",
				"绮丽", "雪莉", "樱花", "小喜", "朵朵", "田田", "小红", "宝娜", "梅子", "小樱",
				"嘻嘻", "云儿", "小草", "小黄", "纳香", "阿梅", "茶花", "哈哈", "芸儿", "东东",
				"小羽", "哈豆", "桃子", "茶叶", "双双", "沫沫", "楠楠", "小爱", "麦当娜", "杏仁",
				"椰子", "小王", "泡泡", "小林", "小灰", "马格", "鱼蛋", "小叶", "小李", "晨晨",
				"小琳", "小慧", "布鲁", "晓梅", "绿叶", "甜豆", "小雪", "晓林", "康康", "安妮",
				"樱桃", "香板", "甜甜", "雪花", "虹儿", "美美", "葡萄", "薇儿", "金豆", "雪玲",
				"瑶瑶", "龙眼", "丁香", "晓云", "雪豆", "琪琪", "麦子", "糖果", "雪丽", "小艺",
				"小麦", "小圆", "雨佳", "小火", "麦茶", "圆圆", "春儿", "火灵", "板子", "黑点",
				"冬冬", "火花", "米粒", "喇叭", "晓秋", "跟屁虫", "米果", "欢欢", "爱心", "松子",
				"丫头", "双子", "豆芽", "小子", "彤彤", "棉花糖", "阿贵", "仙儿", "冰淇淋", "小彬",
				"贤儿", "冰棒", "仔仔", "格子", "水果", "悠悠", "莹莹", "巧克力", "梦洁", "汤圆",
				"静香", "茄子", "珍珠"
			};
			return Game1.random.Choose(options3);
		}
		case LocalizedContentManager.LanguageCode.ru:
		{
			string[] options4 = new string[50]
			{
				"Августина", "Альф", "Анфиса", "Ариша", "Афоня", "Баламут", "Балкан", "Бандит", "Бланка", "Бобик",
				"Боня", "Борька", "Буренка", "Бусинка", "Вася", "Гаврюша", "Глаша", "Гоша", "Дуня", "Дуся",
				"Зорька", "Ивонна", "Игнат", "Кеша", "Клара", "Кузя", "Лада", "Максимус", "Маня", "Марта",
				"Маруся", "Моня", "Мотя", "Мурзик", "Мурка", "Нафаня", "Ника", "Нюша", "Проша", "Пятнушка",
				"Сеня", "Сивка", "Тихон", "Тоша", "Фунтик", "Шайтан", "Юнона", "Юпитер", "Ягодка", "Яшка"
			};
			return Game1.random.Choose(options4);
		}
		default:
		{
			int num = Game1.random.Next(3, 6);
			string[] array = new string[24]
			{
				"B", "Br", "J", "F", "S", "M", "C", "Ch", "L", "P",
				"K", "W", "G", "Z", "Tr", "T", "Gr", "Fr", "Pr", "N",
				"Sn", "R", "Sh", "St"
			};
			string[] options = new string[12]
			{
				"ll", "tch", "l", "m", "n", "p", "r", "s", "t", "c",
				"rt", "ts"
			};
			string[] array2 = new string[5] { "a", "e", "i", "o", "u" };
			string[] options2 = new string[5] { "ie", "o", "a", "ers", "ley" };
			Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
			dictionary["a"] = new string[6] { "nie", "bell", "bo", "boo", "bella", "s" };
			dictionary["e"] = new string[4] { "ll", "llo", "", "o" };
			dictionary["i"] = new string[18]
			{
				"ck", "e", "bo", "ba", "lo", "la", "to", "ta", "no", "na",
				"ni", "a", "o", "zor", "que", "ca", "co", "mi"
			};
			dictionary["o"] = new string[12]
			{
				"nie", "ze", "dy", "da", "o", "ver", "la", "lo", "s", "ny",
				"mo", "ra"
			};
			dictionary["u"] = new string[4] { "rt", "mo", "", "s" };
			Dictionary<string, string[]> dictionary2 = dictionary;
			dictionary = new Dictionary<string, string[]>();
			dictionary["a"] = new string[12]
			{
				"nny", "sper", "trina", "bo", "-bell", "boo", "lbert", "sko", "sh", "ck",
				"ishe", "rk"
			};
			dictionary["e"] = new string[9] { "lla", "llo", "rnard", "cardo", "ffe", "ppo", "ppa", "tch", "x" };
			dictionary["i"] = new string[18]
			{
				"llard", "lly", "lbo", "cky", "card", "ne", "nnie", "lbert", "nono", "nano",
				"nana", "ana", "nsy", "msy", "skers", "rdo", "rda", "sh"
			};
			dictionary["o"] = new string[17]
			{
				"nie", "zzy", "do", "na", "la", "la", "ver", "ng", "ngus", "ny",
				"-mo", "llo", "ze", "ra", "ma", "cco", "z"
			};
			dictionary["u"] = new string[11]
			{
				"ssie", "bbie", "ffy", "bba", "rt", "s", "mby", "mbo", "mbus", "ngus",
				"cky"
			};
			Dictionary<string, string[]> dictionary3 = dictionary;
			string text = array[Game1.random.Next(array.Length - 1)];
			for (int i = 1; i < num - 1; i++)
			{
				text = ((i % 2 != 0) ? (text + Game1.random.Choose(array2)) : (text + Game1.random.Choose(options)));
				if (text.Length >= num)
				{
					break;
				}
			}
			string text2 = text[text.Length - 1].ToString();
			if (Game1.random.NextBool() && !Enumerable.Contains(array2, text2))
			{
				text += Game1.random.Choose(options2);
			}
			else if (Enumerable.Contains(array2, text2))
			{
				if (Game1.random.NextDouble() < 0.8)
				{
					text = ((text.Length > 3) ? (text + Game1.random.ChooseFrom(dictionary2[text2])) : (text + Game1.random.ChooseFrom(dictionary3[text2])));
				}
			}
			else
			{
				text += Game1.random.Choose(array2);
			}
			for (int num2 = text.Length - 1; num2 > 2; num2--)
			{
				if (Enumerable.Contains(array2, text[num2].ToString()) && Enumerable.Contains(array2, text[num2 - 2].ToString()))
				{
					switch (text[num2 - 1])
					{
					case 'c':
						text = text.Substring(0, num2) + "k" + text.Substring(num2);
						num2--;
						break;
					case 'r':
						text = text.Substring(0, num2 - 1) + "k" + text.Substring(num2);
						num2--;
						break;
					case 'l':
						text = text.Substring(0, num2 - 1) + "n" + text.Substring(num2);
						num2--;
						break;
					}
				}
			}
			if (text.Length <= 3 && Game1.random.NextDouble() < 0.1)
			{
				text = (Game1.random.NextBool() ? (text + text) : (text + "-" + text));
			}
			if (text.Length <= 2 && text.Last() == 'e')
			{
				text += Game1.random.Choose('m', 'p', 'b');
			}
			return ReplaceBadRandomName(text);
		}
		}
	}

	public static string ReplaceBadRandomName(string name)
	{
		string text = name.ToLower();
		if (text.Contains("bitch") || text.Contains("cock") || text.Contains("cum") || text.Contains("fuck") || text.Contains("goock") || text.Contains("gook") || text.Contains("kike") || text.Contains("nigg") || text.Contains("pusie") || text.Contains("puss") || text.Contains("puta") || text.Contains("rape") || text.Contains("sex") || text.Contains("shart") || text.Contains("shit") || text.Contains("taboo") || text.Contains("trann") || text.Contains("willy"))
		{
			return Game1.random.Choose("Bobo", "Wumbus");
		}
		switch (text)
		{
		case "boner":
		case "boners":
			return "Boneo";
		case "bussie":
			return "Busu";
		case "cucka":
		case "cucke":
		case "cucko":
		case "cucky":
		case "cuckas":
		case "cuckie":
		case "cuckos":
		case "cuckers":
			return "Cubbie";
		case "grope":
		case "gropers":
			return "Gropello";
		case "natsi":
			return "Natsia";
		case "packi":
		case "packie":
			return "Packina";
		case "penos":
		case "penus":
			return "Penono";
		case "rapie":
			return "Rapimi";
		case "trapi":
		case "trani":
		case "tranie":
		case "trapie":
		case "trananie":
			return "Tranello";
		default:
			return name;
		}
	}

	public virtual string exitCurrentDialogue()
	{
		if (isOnFinalDialogue())
		{
			currentDialogueIndex++;
			applyAndSkipPlainSideEffects();
			onFinish?.Invoke();
		}
		bool num = isCurrentStringContinuedOnNextScreen;
		if (currentDialogueIndex < dialogues.Count - 1)
		{
			currentDialogueIndex++;
			applyAndSkipPlainSideEffects();
			checkForSpecialDialogueAttributes();
		}
		else
		{
			finishedLastDialogue = true;
		}
		if (num)
		{
			return getCurrentDialogue();
		}
		return null;
	}

	private void checkForSpecialDialogueAttributes()
	{
		CurrentEmotion = null;
		isCurrentStringContinuedOnNextScreen = false;
		dontFaceFarmer = false;
		if (currentDialogueIndex < dialogues.Count)
		{
			DialogueLine dialogueLine = dialogues[currentDialogueIndex];
			if (dialogueLine.Text.Contains("{"))
			{
				dialogueLine.Text = dialogueLine.Text.Replace("{", "");
				isCurrentStringContinuedOnNextScreen = true;
			}
			if (dialogueLine.Text.Contains("%noturn"))
			{
				dialogueLine.Text = dialogueLine.Text.Replace("%noturn", "");
				dontFaceFarmer = true;
			}
			checkEmotions();
		}
	}

	private void checkEmotions()
	{
		CurrentEmotion = null;
		if (currentDialogueIndex >= dialogues.Count)
		{
			return;
		}
		DialogueLine dialogueLine = dialogues[currentDialogueIndex];
		string text = dialogueLine.Text;
		int num = text.IndexOf('$');
		if (num == -1 || dialogues.Count <= 0)
		{
			return;
		}
		if (text.Contains("$h"))
		{
			CurrentEmotion = "$h";
			dialogueLine.Text = text.Replace("$h", "");
			return;
		}
		if (text.Contains("$s"))
		{
			CurrentEmotion = "$s";
			dialogueLine.Text = text.Replace("$s", "");
			return;
		}
		if (text.Contains("$u"))
		{
			CurrentEmotion = "$u";
			dialogueLine.Text = text.Replace("$u", "");
			return;
		}
		if (text.Contains("$l"))
		{
			CurrentEmotion = "$l";
			dialogueLine.Text = text.Replace("$l", "");
			return;
		}
		if (text.Contains("$a"))
		{
			CurrentEmotion = "$a";
			dialogueLine.Text = text.Replace("$a", "");
			return;
		}
		int num2 = 0;
		for (int i = num + 1; i < text.Length && char.IsDigit(text[i]); i++)
		{
			num2++;
		}
		if (num2 > 0)
		{
			string oldValue = (CurrentEmotion = text.Substring(num, num2 + 1));
			dialogueLine.Text = text.Replace(oldValue, "");
		}
	}

	public List<NPCDialogueResponse> getNPCResponseOptions()
	{
		return playerResponses;
	}

	public Response[] getResponseOptions()
	{
		return playerResponses.Cast<Response>().ToArray();
	}

	public bool isCurrentDialogueAQuestion()
	{
		if (isLastDialogueInteractive)
		{
			return currentDialogueIndex == dialogues.Count - 1;
		}
		return false;
	}

	public virtual bool chooseResponse(Response response)
	{
		for (int i = 0; i < playerResponses.Count; i++)
		{
			if (playerResponses[i].responseKey == null || response.responseKey == null || !playerResponses[i].responseKey.Equals(response.responseKey))
			{
				continue;
			}
			if (answerQuestionBehavior != null)
			{
				if (answerQuestionBehavior(i))
				{
					Game1.currentSpeaker = null;
				}
				isLastDialogueInteractive = false;
				finishedLastDialogue = true;
				answerQuestionBehavior = null;
				return true;
			}
			if (quickResponse)
			{
				isLastDialogueInteractive = false;
				finishedLastDialogue = true;
				isCurrentStringContinuedOnNextScreen = true;
				speaker.setNewDialogue(new Dialogue(speaker, null, quickResponses[i]));
				Game1.drawDialogue(speaker);
				speaker.faceTowardFarmerForPeriod(4000, 3, faceAway: false, farmer);
				return true;
			}
			if (Game1.isFestival())
			{
				Game1.currentLocation.currentEvent.answerDialogueQuestion(speaker, playerResponses[i].responseKey);
				isLastDialogueInteractive = false;
				finishedLastDialogue = true;
				return false;
			}
			farmer.changeFriendship(playerResponses[i].friendshipChange, speaker);
			if (playerResponses[i].id != null)
			{
				farmer.addSeenResponse(playerResponses[i].id);
			}
			if (playerResponses[i].extraArgument != null)
			{
				try
				{
					performDialogueResponseExtraArgument(farmer, playerResponses[i].extraArgument);
				}
				catch (Exception)
				{
				}
			}
			isLastDialogueInteractive = false;
			finishedLastDialogue = false;
			parseDialogueString(speaker.Dialogue[playerResponses[i].responseKey], speaker.LoadedDialogueKey + ":" + playerResponses[i].responseKey);
			isCurrentStringContinuedOnNextScreen = true;
			return false;
		}
		return false;
	}

	public void performDialogueResponseExtraArgument(Farmer farmer, string argument)
	{
		string[] array = argument.Split("_");
		if (array[0].EqualsIgnoreCase("friend"))
		{
			farmer.changeFriendship(Convert.ToInt32(array[2]), Game1.getCharacterFromName(array[1]));
		}
	}

	public void convertToDwarvish()
	{
		for (int i = 0; i < dialogues.Count; i++)
		{
			dialogues[i].Text = convertToDwarvish(dialogues[i].Text);
		}
	}

	public static string convertToDwarvish(string str)
	{
		if (Game1.content.GetCurrentLanguage() == LocalizedContentManager.LanguageCode.zh)
		{
			string text = "bcdfghjklmnpqrstvwxyz";
			string text2 = "bcd fghj klmn pqrst vwxy z";
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = true;
			foreach (char c in str)
			{
				int num = c;
				if ((19968 <= num && num <= 40959) || (12352 <= num && num <= 12543) || c == '々' || (44032 <= num && num <= 55215))
				{
					char c2 = text[num % text.Length];
					if (flag)
					{
						c2 = char.ToUpper(c2);
						flag = false;
					}
					stringBuilder.Append(c2);
					char value = text2[(num >> 1) % text2.Length];
					stringBuilder.Append(value);
				}
				else
				{
					stringBuilder.Append(c);
					if (c != ' ')
					{
						flag = true;
					}
				}
			}
			return stringBuilder.ToString();
		}
		StringBuilder stringBuilder2 = new StringBuilder();
		for (int j = 0; j < str.Length; j++)
		{
			switch (str[j])
			{
			case 'a':
				stringBuilder2.Append('o');
				continue;
			case 'e':
				stringBuilder2.Append('u');
				continue;
			case 'i':
				stringBuilder2.Append("e");
				continue;
			case 'o':
				stringBuilder2.Append('a');
				continue;
			case 'u':
				stringBuilder2.Append("i");
				continue;
			case 'y':
				stringBuilder2.Append("ol");
				continue;
			case 'z':
				stringBuilder2.Append('b');
				continue;
			case 'A':
				stringBuilder2.Append('O');
				continue;
			case 'E':
				stringBuilder2.Append('U');
				continue;
			case 'I':
				stringBuilder2.Append("E");
				continue;
			case 'O':
				stringBuilder2.Append('A');
				continue;
			case 'U':
				stringBuilder2.Append("I");
				continue;
			case 'Y':
				stringBuilder2.Append("Ol");
				continue;
			case 'Z':
				stringBuilder2.Append('B');
				continue;
			case '1':
				stringBuilder2.Append('M');
				continue;
			case '5':
				stringBuilder2.Append('X');
				continue;
			case '9':
				stringBuilder2.Append('V');
				continue;
			case '0':
				stringBuilder2.Append('Q');
				continue;
			case 'g':
				stringBuilder2.Append('l');
				continue;
			case 'c':
				stringBuilder2.Append('t');
				continue;
			case 't':
				stringBuilder2.Append('n');
				continue;
			case 'd':
				stringBuilder2.Append('p');
				continue;
			case ' ':
			case '!':
			case '"':
			case '\'':
			case ',':
			case '.':
			case '?':
			case 'h':
			case 'm':
			case 's':
				stringBuilder2.Append(str[j]);
				continue;
			case '\n':
			case 'n':
			case 'p':
				continue;
			}
			if (char.IsLetterOrDigit(str[j]))
			{
				stringBuilder2.Append((char)(str[j] + 2));
			}
		}
		return stringBuilder2.ToString().Replace("nhu", "doo");
	}
}
