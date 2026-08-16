using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley.Buffs;
using StardewValley.Monsters;

namespace StardewValley.Enchantments;

[XmlInclude(typeof(ReachingToolEnchantment))]
[XmlInclude(typeof(ShavingEnchantment))]
[XmlInclude(typeof(SwiftToolEnchantment))]
[XmlInclude(typeof(FisherEnchantment))]
[XmlInclude(typeof(AmethystEnchantment))]
[XmlInclude(typeof(AquamarineEnchantment))]
[XmlInclude(typeof(DiamondEnchantment))]
[XmlInclude(typeof(EmeraldEnchantment))]
[XmlInclude(typeof(JadeEnchantment))]
[XmlInclude(typeof(RubyEnchantment))]
[XmlInclude(typeof(GalaxySoulEnchantment))]
[XmlInclude(typeof(AttackEnchantment))]
[XmlInclude(typeof(DefenseEnchantment))]
[XmlInclude(typeof(SlimeSlayerEnchantment))]
[XmlInclude(typeof(CritEnchantment))]
[XmlInclude(typeof(WeaponSpeedEnchantment))]
[XmlInclude(typeof(CritPowerEnchantment))]
[XmlInclude(typeof(LightweightEnchantment))]
[XmlInclude(typeof(SlimeGathererEnchantment))]
[XmlInclude(typeof(PreservingEnchantment))]
[XmlInclude(typeof(TopazEnchantment))]
[XmlInclude(typeof(PowerfulEnchantment))]
[XmlInclude(typeof(GenerousEnchantment))]
[XmlInclude(typeof(MasterEnchantment))]
[XmlInclude(typeof(ArtfulEnchantment))]
[XmlInclude(typeof(BugKillerEnchantment))]
[XmlInclude(typeof(CrusaderEnchantment))]
[XmlInclude(typeof(HaymakerEnchantment))]
[XmlInclude(typeof(MagicEnchantment))]
[XmlInclude(typeof(VampiricEnchantment))]
[XmlInclude(typeof(AxeEnchantment))]
[XmlInclude(typeof(BaseWeaponEnchantment))]
[XmlInclude(typeof(MilkPailEnchantment))]
[XmlInclude(typeof(PanEnchantment))]
[XmlInclude(typeof(PickaxeEnchantment))]
[XmlInclude(typeof(ShearsEnchantment))]
[XmlInclude(typeof(WateringCanEnchantment))]
[XmlInclude(typeof(ArchaeologistEnchantment))]
[XmlInclude(typeof(AutoHookEnchantment))]
[XmlInclude(typeof(BottomlessEnchantment))]
[XmlInclude(typeof(EfficientToolEnchantment))]
[XmlInclude(typeof(HoeEnchantment))]
public class BaseEnchantment : INetObject<NetFields>
{
	[XmlIgnore]
	protected string _displayName;

	[XmlIgnore]
	protected bool _applied;

	[XmlIgnore]
	[InstancedStatic]
	public static bool hideEnchantmentName;

	[XmlIgnore]
	[InstancedStatic]
	public static bool hideSecondaryEnchantName;

	protected static List<BaseEnchantment> _enchantments;

	protected readonly NetInt level;

	[XmlIgnore]
	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlElement("level")]
	public int Level
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
	public BaseEnchantment()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BaseEnchantment GetEnchantmentFromItem(Item base_item, Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<BaseEnchantment> GetAvailableEnchantmentsForItem(Tool item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<BaseEnchantment> GetAvailableEnchantments()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ResetEnchantments()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsForge()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsSecondaryEnchantment()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitializeNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEquip(Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnUnequip(Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _OnEquip(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _OnUnequip(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnCalculateDamage(Monster monster, GameLocation location, Farmer who, bool fromBomb, ref int amount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDealtDamage(Monster monster, GameLocation location, Farmer who, bool fromBomb, int amount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnMonsterSlay(Monster monster, GameLocation location, Farmer who, bool slainByBomb)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddEquipmentEffects(BuffEffects effects)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCutWeed(Vector2 tile_location, GameLocation location, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _OnCutWeed(Vector2 tile_location, GameLocation location, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual BaseEnchantment GetOne()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetLevel()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLevel(Item item, int new_level)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetMaximumLevel()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyTo(Item item, Farmer farmer = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _ApplyTo(Item item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsItemCurrentlyEquipped(Item item, Farmer farmer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool _IsCurrentlyEquipped(Item item, Farmer farmer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnapplyTo(Item item, Farmer farmer = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _UnapplyTo(Item item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanApplyTo(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDisplayName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ShouldBeDisplayed()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
