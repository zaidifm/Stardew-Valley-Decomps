using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace StardewValley.Enchantments;

[XmlInclude(typeof(FishingRodEnchantment))]
public class FishingRodEnchantment : BaseEnchantment
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanApplyTo(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FishingRodEnchantment()
	{
	}
}
