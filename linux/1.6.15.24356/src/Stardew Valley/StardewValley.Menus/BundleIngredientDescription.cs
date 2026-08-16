namespace StardewValley.Menus;

public struct BundleIngredientDescription
{
	public readonly string id;

	public string preservesId;

	public readonly int? category;

	public readonly int stack;

	public readonly int quality;

	public bool completed;

	public BundleIngredientDescription(string idOrCategory, int stack, int quality, bool completed, string preservesId = null)
	{
		this.stack = stack;
		this.quality = quality;
		this.completed = completed;
		this.preservesId = preservesId;
		if (int.TryParse(idOrCategory, out var result) && result < 0)
		{
			id = null;
			category = result;
		}
		else
		{
			id = idOrCategory;
			category = null;
		}
	}

	public BundleIngredientDescription(BundleIngredientDescription other, bool completed)
	{
		id = other.id;
		category = other.category;
		stack = other.stack;
		quality = other.quality;
		preservesId = other.preservesId;
		this.completed = completed;
	}
}
