using System.Runtime.CompilerServices;

namespace StardewValley.ItemTypeDefinitions;

public class ItemMetadata
{
	private ParsedItemData ParsedData;

	private bool IsParsedDataLoaded;

	private IItemDataDefinition TypeDefinition;

	private bool IsTypeResolveAttempted;

	private bool TypeDefinitionContainsItem;

	public string LocalItemId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public string QualifiedItemId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public string TypeIdentifier
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemMetadata(string qualifiedItemId, string localItemId, string typeIdentifier)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SetTypeDefinition(string typeIdentifier, IItemDataDefinition typeDefinition, bool? itemExists = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IItemDataDefinition GetTypeDefinition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ParsedItemData GetParsedData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ParsedItemData GetParsedOrErrorData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Exists()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item CreateItem(int amount = 1, int quality = 0)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item CreateItemOrErrorItem(int amount = 1, int quality = 0)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
