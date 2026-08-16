using System.Runtime.CompilerServices;

namespace rail;

public class RoomInfoListSorter
{
	public double close_to_value;

	public string property_key;

	public EnumRailSortType property_sort_type;

	public EnumRailPropertyValueType property_value_type;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RoomInfoListSorter()
	{
	}
}
