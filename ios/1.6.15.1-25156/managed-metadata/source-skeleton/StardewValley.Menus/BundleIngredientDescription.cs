using System.Runtime.CompilerServices;

namespace StardewValley.Menus;

public struct BundleIngredientDescription
{
	public readonly string id;

	public string preservesId;

	public readonly int? category;

	public readonly int stack;

	public readonly int quality;

	public bool completed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BundleIngredientDescription(string idOrCategory, int stack, int quality, bool completed, string preservesId = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BundleIngredientDescription(BundleIngredientDescription other, bool completed)
	{
	}
}
