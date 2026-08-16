using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class UpdateAssetsPropertyFinished : EventBase
{
	public List<RailAssetProperty> asset_property_list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UpdateAssetsPropertyFinished()
	{
	}
}
