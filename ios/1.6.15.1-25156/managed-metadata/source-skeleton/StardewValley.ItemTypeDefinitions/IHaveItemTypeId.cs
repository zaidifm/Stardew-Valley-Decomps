using System.Runtime.CompilerServices;

namespace StardewValley.ItemTypeDefinitions;

public interface IHaveItemTypeId
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	string GetItemTypeId();
}
