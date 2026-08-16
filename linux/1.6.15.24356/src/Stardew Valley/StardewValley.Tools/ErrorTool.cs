namespace StardewValley.Tools;

public class ErrorTool : Tool
{
	public ErrorTool()
		: base("Error Item", 0, 0, 0, stackable: false)
	{
	}

	public ErrorTool(string itemId, int upgradeLevel = 0, int numAttachmentSlots = 0)
		: base("Error Item", upgradeLevel, 0, 0, stackable: false, numAttachmentSlots)
	{
		base.ItemId = itemId;
		Name = "Error Item";
	}

	protected override Item GetOneNew()
	{
		return new ErrorTool(base.ItemId, base.UpgradeLevel, numAttachmentSlots.Value);
	}

	protected override string loadDescription()
	{
		return ItemRegistry.RequireTypeDefinition("(T)").GetErrorData(base.ItemId).Description;
	}

	protected override string loadDisplayName()
	{
		return ItemRegistry.RequireTypeDefinition("(T)").GetErrorData(base.ItemId).DisplayName;
	}
}
