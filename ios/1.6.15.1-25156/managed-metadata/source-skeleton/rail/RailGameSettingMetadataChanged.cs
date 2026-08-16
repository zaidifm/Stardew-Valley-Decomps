using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailGameSettingMetadataChanged : EventBase
{
	public List<RailKeyValue> key_values;

	public RailGameSettingMetadataChangedSource source;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailGameSettingMetadataChanged()
	{
	}
}
