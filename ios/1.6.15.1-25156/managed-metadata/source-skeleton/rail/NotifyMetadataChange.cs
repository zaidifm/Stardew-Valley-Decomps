using System.Runtime.CompilerServices;

namespace rail;

public class NotifyMetadataChange : EventBase
{
	public RailID changer_id;

	public ulong room_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NotifyMetadataChange()
	{
	}
}
