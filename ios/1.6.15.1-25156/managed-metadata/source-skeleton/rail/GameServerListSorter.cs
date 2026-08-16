using System.Runtime.CompilerServices;

namespace rail;

public class GameServerListSorter
{
	public string sort_key;

	public EnumRailSortType sort_type;

	public GameServerListSorterKeyType sorter_key_type;

	public EnumRailPropertyValueType sort_value_type;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameServerListSorter()
	{
	}
}
