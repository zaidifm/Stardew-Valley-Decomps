namespace StardewValley.Tools;

public class GenericTool : Tool
{
	protected override Item GetOneNew()
	{
		return new GenericTool();
	}
}
