using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Buffs;
using StardewValley.Extensions;
using StardewValley.TokenizableStrings;

namespace StardewValley;

public class Buff
{
	public const float glowRate = 0.05f;

	public const int ENDLESS = -2;

	public const int farming = 0;

	public const int fishing = 1;

	public const int mining = 2;

	public const int luck = 4;

	public const int foraging = 5;

	public const int maxStamina = 7;

	public const int magneticRadius = 8;

	public const int speed = 9;

	public const int defense = 10;

	public const int attack = 11;

	public const string goblinsCurse = "12";

	public const string slimed = "13";

	public const string evilEye = "14";

	public const string tipsy = "17";

	public const string fear = "18";

	public const string frozen = "19";

	public const string warriorEnergy = "20";

	public const string yobaBlessing = "21";

	public const string adrenalineRush = "22";

	public const string avoidMonsters = "23";

	public const string full = "6";

	public const string quenched = "7";

	public const string spawnMonsters = "24";

	public const string nauseous = "25";

	public const string darkness = "26";

	public const string weakness = "27";

	public const string squidInkRavioli = "28";

	public const int fullnessLength = 180000;

	public const int quenchedLength = 60000;

	public int millisecondsDuration;

	public int totalMillisecondsDuration;

	public readonly BuffEffects effects = new BuffEffects();

	public readonly string id;

	public string displayName;

	public string description;

	public string source;

	public string displaySource;

	public Texture2D iconTexture;

	public int iconSheetIndex;

	public Color glow;

	public float displayAlphaTimer;

	public bool alreadyUpdatedIconAlpha;

	public string[] actionsOnApply;

	public bool visible = true;

	public readonly Dictionary<string, string> customFields = new Dictionary<string, string>();

	public Buff(string id, string source = null, string displaySource = null, int duration = -1, Texture2D iconTexture = null, int iconSheetIndex = -1, BuffEffects effects = null, bool? isDebuff = null, string displayName = null, string description = null)
	{
		this.id = id;
		this.source = source;
		this.displaySource = displaySource;
		bool flag = false;
		if (id != null && DataLoader.Buffs(Game1.content).TryGetValue(id, out var value))
		{
			this.displayName = TokenParser.ParseText(value.DisplayName);
			this.description = TokenParser.ParseText(value.Description);
			glow = Utility.StringToColor(value.GlowColor) ?? glow;
			millisecondsDuration = ((value.MaxDuration > 0 && value.MaxDuration > value.Duration) ? Game1.random.Next(value.Duration, value.MaxDuration + 1) : value.Duration);
			this.iconTexture = ((value.IconTexture == "TileSheets\\BuffsIcons") ? Game1.buffsIcons : Game1.content.Load<Texture2D>(value.IconTexture));
			this.iconSheetIndex = value.IconSpriteIndex;
			this.effects.Add(value.Effects);
			actionsOnApply = value.ActionsOnApply?.ToArray();
			flag = value.IsDebuff;
			customFields.TryAddMany(value.CustomFields);
		}
		if (duration != -1)
		{
			millisecondsDuration = duration;
		}
		if (iconTexture != null)
		{
			this.iconTexture = iconTexture;
		}
		if (iconSheetIndex != -1)
		{
			this.iconSheetIndex = iconSheetIndex;
		}
		if (displayName != null)
		{
			this.displayName = displayName;
		}
		if (description != null)
		{
			this.description = description;
		}
		if ((isDebuff ?? flag) && Game1.player.isWearingRing("525") && millisecondsDuration != -2)
		{
			millisecondsDuration /= 2;
		}
		totalMillisecondsDuration = millisecondsDuration;
		if (effects != null)
		{
			this.effects.Add(effects);
		}
	}

	public bool HasAnyEffects()
	{
		return effects.HasAnyValue();
	}

	public string getTimeLeft()
	{
		return Game1.content.LoadString("Strings\\StringsFromCSFiles:Buff.cs.476") + millisecondsDuration / 60000 + ":" + millisecondsDuration % 60000 / 10000 + millisecondsDuration % 60000 % 10000 / 1000;
	}

	public virtual bool update(GameTime time)
	{
		if (millisecondsDuration == -2 || !Game1.shouldTimePass())
		{
			return false;
		}
		int num = millisecondsDuration;
		millisecondsDuration -= time.ElapsedGameTime.Milliseconds;
		if (id == "13" && num % 500 < millisecondsDuration % 500 && num < 3000)
		{
			Game1.multiplayer.broadcastSprites(Game1.player.currentLocation, new TemporaryAnimatedSprite(44, Game1.player.getStandingPosition() + new Vector2(-40 + Game1.random.Next(-8, 12), Game1.random.Next(-32, -16)), Color.Green * 0.5f, 8, Game1.random.NextBool(), 70f)
			{
				scale = 1f
			});
		}
		if (millisecondsDuration <= 0)
		{
			return true;
		}
		return false;
	}

	public virtual void OnAdded()
	{
		if (id == "19")
		{
			Game1.player.currentLocation.temporarySprites.Add(new TemporaryAnimatedSprite("LooseSprites\\Cursors2", new Rectangle(118, 227, 16, 13), Game1.player.getStandingPosition() + new Vector2(-32f, -21f), flipped: false, 0f, Color.White)
			{
				layerDepth = (float)(Game1.player.StandingPixel.Y + 1) / 10000f,
				animationLength = 1,
				interval = 2000f,
				scale = 4f
			});
		}
	}

	public virtual void OnRemoved()
	{
	}
}
