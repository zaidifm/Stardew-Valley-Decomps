using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Buffs;
using StardewValley.Monsters;

namespace StardewValley.Objects;

[XmlInclude(typeof(CombinedRing))]
public class Ring : Item
{
	public const string SmallGlowRingId = "516";

	public const string GlowRingId = "517";

	public const string SmallMagnetRingId = "518";

	public const string MagnetRingId = "519";

	public const string SlimeCharmerRingId = "520";

	public const string WarriorRingId = "521";

	public const string VampireRingId = "522";

	public const string SavageRingId = "523";

	public const string YobaRingId = "524";

	public const string SturdyRingId = "525";

	public const string BurglarsRingId = "526";

	public const string IridiumBandId = "527";

	public const string AmethystRingId = "529";

	public const string TopazRingId = "530";

	public const string AquamarineRingId = "531";

	public const string JadeRingId = "532";

	public const string EmeraldRingId = "533";

	public const string RubyRingId = "534";

	public const string WeddingRingId = "801";

	public const string CrabshellRingId = "810";

	public const string NapalmRingId = "811";

	public const string ThornsRingId = "839";

	public const string LuckyRingId = "859";

	public const string HotJavaRingId = "860";

	public const string ProtectiveRingId = "861";

	public const string SoulSapperRingId = "862";

	public const string PhoenixRingId = "863";

	public const string CombinedRingId = "880";

	public const string ImmunityBandId = "887";

	public const string GlowstoneRingId = "888";

	[XmlElement("price")]
	public readonly NetInt price;

	[XmlElement("indexInTileSheet")]
	public int? obsolete_indexInTileSheet;

	[XmlIgnore]
	public string description;

	[XmlIgnore]
	public string displayName;

	[XmlIgnore]
	public string lightSourceId;

	public override string TypeDefinitionId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public override string DisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void MigrateLegacyItemId()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Ring()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Ring(string itemId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanBeLostOnDeath()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void onEquip(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void onUnequip(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AddEquipmentEffects(BuffEffects effects)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string getCategoryName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onNewLocation(Farmer who, GameLocation environment)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveLocation(Farmer who, GameLocation environment)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int salePrice(bool ignoreProfitMargins = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMonsterSlay(Monster monster, GameLocation location, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void update(GameTime time, GameLocation environment, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int maximumStackSize()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Point getExtraSpaceNeededForTooltipSpecialIcons(SpriteFont font, int minWidth, int horizontalBuffer, int startingHeight, StringBuilder descriptionText, string boldTitleText, int moneyAmountToDisplayAtBottom)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool GetsEffectOfRing(string ringId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetEffectsOfRingMultiplier(string ringId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawTooltip(SpriteBatch spriteBatch, ref int x, ref int y, SpriteFont font, float alpha, StringBuilder overrideText)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string getDescription()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isPlaceable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Item GetOneNew()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool loadDisplayFields()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanCombine(Ring ring)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Ring Combine(Ring ring)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
