using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley.GameData;
using StardewValley.Monsters;
using StardewValley.Network;

namespace StardewValley.Objects.Trinkets;

public class Trinket : Object
{
	protected string _description;

	protected TrinketData _data;

	protected TrinketEffect _trinketEffect;

	protected string _trinketEffectClassName;

	protected string displayNameOverride;

	public readonly NetString displayNameOverrideTemplate;

	public readonly NetStringList descriptionSubstitutionTemplates;

	public readonly NetStringDictionary<string, NetString> trinketMetadata;

	[XmlElement("generationSeed")]
	public readonly NetInt generationSeed;

	public override string TypeDefinitionId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Trinket()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Trinket(string itemId, int generationSeed)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CanSpawnTrinket(Farmer f)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SpawnTrinket(GameLocation location, Vector2 spawnPoint)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool RerollStats(int newSeed)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool canBeShipped()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int sellToStorePrice(long specificPlayerID = -1L)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void TrySpawnTrinket(GameLocation location, Monster monster, Vector2 spawnPosition, double chanceModifier = 1.0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Trinket GetRandomTrinket()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool canBeGivenAsGift()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void reloadSprite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TrinketData GetTrinketData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual TrinketEffect GetEffect()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override string loadDisplayName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int maximumStackSize()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string getDescription()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string getCategoryName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Color getCategoryColor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isPlaceable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performUseAction(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performToolAction(Tool t)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Item GetOneNew()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void GetOneCopyFrom(Item source)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsHeldOverHead()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Apply(Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Unapply(Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update(Farmer farmer, GameTime time, GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnFootstep(Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnReceiveDamage(Farmer farmer, int damageAmount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDamageMonster(Farmer farmer, Monster monster, int damageAmount)
	{
	}
}
