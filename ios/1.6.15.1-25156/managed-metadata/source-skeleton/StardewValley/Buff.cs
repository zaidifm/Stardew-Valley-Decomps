using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Buffs;

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

	public readonly BuffEffects effects;

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

	public bool visible;

	public readonly Dictionary<string, string> customFields;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Buff(string id, string source = null, string displaySource = null, int duration = -1, Texture2D iconTexture = null, int iconSheetIndex = -1, BuffEffects effects = null, bool? isDebuff = false, string displayName = null, string description = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasAnyEffects()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getTimeLeft()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool update(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnAdded()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRemoved()
	{
	}
}
