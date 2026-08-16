using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley.GameData;
using StardewValley.ItemTypeDefinitions;
using StardewValley.Monsters;
using StardewValley.Network;
using StardewValley.TokenizableStrings;

namespace StardewValley.Objects.Trinkets;

public class Trinket : Object
{
	protected string _description;

	protected TrinketData _data;

	protected TrinketEffect _trinketEffect;

	protected string _trinketEffectClassName;

	protected string displayNameOverride;

	public readonly NetString displayNameOverrideTemplate = new NetString();

	public readonly NetStringList descriptionSubstitutionTemplates = new NetStringList();

	public readonly NetStringDictionary<string, NetString> trinketMetadata = new NetStringDictionary<string, NetString>();

	[XmlElement("generationSeed")]
	public readonly NetInt generationSeed = new NetInt();

	public override string TypeDefinitionId { get; } = "(TR)";

	public Trinket()
	{
	}

	public Trinket(string itemId, int generationSeed)
		: this()
	{
		base.ItemId = itemId;
		base.name = itemId;
		this.generationSeed.Value = generationSeed;
		ParsedItemData dataOrErrorItem = ItemRegistry.GetDataOrErrorItem(itemId);
		base.ParentSheetIndex = dataOrErrorItem.SpriteIndex;
		Dictionary<string, string> dictionary = GetTrinketData()?.ModData;
		if (dictionary != null && dictionary.Count > 0)
		{
			foreach (KeyValuePair<string, string> item in dictionary)
			{
				base.modData.Add(item.Key, item.Value);
			}
		}
		GetEffect()?.GenerateRandomStats(this);
	}

	public static bool CanSpawnTrinket(Farmer f)
	{
		return f.stats.Get("trinketSlots") != 0;
	}

	public static void SpawnTrinket(GameLocation location, Vector2 spawnPoint)
	{
		Trinket randomTrinket = GetRandomTrinket();
		if (randomTrinket != null)
		{
			Game1.createItemDebris(randomTrinket, spawnPoint, Game1.random.Next(4), location);
		}
	}

	public bool RerollStats(int newSeed)
	{
		generationSeed.Value = newSeed;
		return GetEffect()?.GenerateRandomStats(this) ?? false;
	}

	public override bool canBeShipped()
	{
		return false;
	}

	public override int sellToStorePrice(long specificPlayerID = -1L)
	{
		return 1000;
	}

	public static void TrySpawnTrinket(GameLocation location, Monster monster, Vector2 spawnPosition, double chanceModifier = 1.0)
	{
		if (!CanSpawnTrinket(Game1.player))
		{
			return;
		}
		double num = 0.004;
		if (monster != null)
		{
			num += (double)monster.MaxHealth * 1E-05;
			if (monster.isGlider.Value && monster.MaxHealth >= 150)
			{
				num += 0.002;
			}
			if (monster is Leaper)
			{
				num -= 0.005;
			}
		}
		num = Math.Min(0.025, num);
		num += Game1.player.DailyLuck / 25.0;
		num += (double)((float)Game1.player.LuckLevel * 0.00133f);
		num *= chanceModifier;
		if (Game1.random.NextDouble() < num)
		{
			SpawnTrinket(location, spawnPosition);
		}
	}

	public static Trinket GetRandomTrinket()
	{
		Dictionary<string, TrinketData> dictionary = DataLoader.Trinkets(Game1.content);
		Trinket trinket = null;
		while (trinket == null)
		{
			int num = Game1.random.Next(dictionary.Count);
			int num2 = 0;
			foreach (KeyValuePair<string, TrinketData> item in dictionary)
			{
				if (num == num2 && item.Value.DropsNaturally)
				{
					trinket = ItemRegistry.Create<Trinket>("(TR)" + item.Key);
					break;
				}
				num2++;
			}
		}
		return trinket;
	}

	public override bool canBeGivenAsGift()
	{
		return true;
	}

	public override void reloadSprite()
	{
		base.reloadSprite();
		GetEffect()?.GenerateRandomStats(this);
	}

	protected override void initNetFields()
	{
		base.initNetFields();
		base.NetFields.AddField(trinketMetadata, "trinketMetadata").AddField(generationSeed, "generationSeed").AddField(displayNameOverrideTemplate, "displayNameOverrideTemplate")
			.AddField(descriptionSubstitutionTemplates, "descriptionSubstitutionTemplates");
		displayNameOverrideTemplate.fieldChangeVisibleEvent += delegate(NetString field, string oldValue, string newValue)
		{
			displayNameOverride = TokenParser.ParseText(newValue);
		};
		descriptionSubstitutionTemplates.OnElementChanged += delegate
		{
			_description = null;
		};
		descriptionSubstitutionTemplates.OnArrayReplaced += delegate
		{
			_description = null;
		};
	}

	public TrinketData GetTrinketData()
	{
		if (_data == null)
		{
			_data = DataLoader.Trinkets(Game1.content).GetValueOrDefault(base.ItemId);
		}
		return _data;
	}

	public virtual TrinketEffect GetEffect()
	{
		if (_trinketEffect == null)
		{
			TrinketData trinketData = GetTrinketData();
			if (trinketData != null && _trinketEffectClassName != trinketData.TrinketEffectClass)
			{
				_trinketEffectClassName = trinketData.TrinketEffectClass;
				if (trinketData.TrinketEffectClass != null)
				{
					Type type = System.Type.GetType(trinketData.TrinketEffectClass);
					if (type != null)
					{
						_trinketEffect = (TrinketEffect)Activator.CreateInstance(type, this);
					}
					else
					{
						Game1.log.Warn($"Failed loading effects for trinket {base.QualifiedItemId}: invalid class type '{trinketData.TrinketEffectClass}'.");
					}
				}
			}
		}
		return _trinketEffect;
	}

	protected override string loadDisplayName()
	{
		ParsedItemData dataOrErrorItem = ItemRegistry.GetDataOrErrorItem(base.ItemId);
		return displayNameOverride ?? dataOrErrorItem.DisplayName;
	}

	public override int maximumStackSize()
	{
		return 1;
	}

	public override string getDescription()
	{
		if (_description == null)
		{
			string text = TokenParser.ParseText(ItemRegistry.GetDataOrErrorItem(base.ItemId).Description);
			if (descriptionSubstitutionTemplates.Count > 0)
			{
				object[] array = new object[descriptionSubstitutionTemplates.Count];
				for (int i = 0; i < descriptionSubstitutionTemplates.Count; i++)
				{
					array[i] = TokenParser.ParseText(descriptionSubstitutionTemplates[i]);
				}
				text = string.Format(text, array);
			}
			_description = Game1.parseText(text, Game1.smallFont, getDescriptionWidth());
		}
		return _description;
	}

	public override string getCategoryName()
	{
		return Game1.content.LoadString("Strings\\1_6_Strings:Trinket");
	}

	public override Color getCategoryColor()
	{
		return new Color(96, 81, 255);
	}

	public override bool isPlaceable()
	{
		return false;
	}

	public override bool performUseAction(GameLocation location)
	{
		GetEffect().OnUse(Game1.player);
		return false;
	}

	public override bool performToolAction(Tool t)
	{
		return false;
	}

	protected override Item GetOneNew()
	{
		return new Trinket(base.ItemId, generationSeed.Value);
	}

	protected override void GetOneCopyFrom(Item source)
	{
		base.GetOneCopyFrom(source);
		if (source is Trinket trinket)
		{
			displayNameOverrideTemplate.Value = trinket.displayNameOverrideTemplate.Value;
			descriptionSubstitutionTemplates.Set(trinket.descriptionSubstitutionTemplates);
			trinketMetadata.Set(trinket.trinketMetadata.Pairs);
			generationSeed.Value = trinket.generationSeed.Value;
		}
	}

	public override bool IsHeldOverHead()
	{
		return false;
	}

	public virtual void Apply(Farmer farmer)
	{
		GetEffect()?.Apply(farmer);
	}

	public virtual void Unapply(Farmer farmer)
	{
		GetEffect()?.Unapply(farmer);
	}

	public virtual void Update(Farmer farmer, GameTime time, GameLocation location)
	{
		GetEffect()?.Update(farmer, time, location);
	}

	public virtual void OnFootstep(Farmer farmer)
	{
		GetEffect()?.OnFootstep(farmer);
	}

	public virtual void OnReceiveDamage(Farmer farmer, int damageAmount)
	{
		GetEffect()?.OnReceiveDamage(farmer, damageAmount);
	}

	public virtual void OnDamageMonster(Farmer farmer, Monster monster, int damageAmount, bool isBomb, bool isCriticalHit)
	{
		GetEffect()?.OnDamageMonster(farmer, monster, damageAmount, isBomb, isCriticalHit);
	}
}
