using System.Runtime.CompilerServices;

namespace rail;

public class RoomDataReceived : EventBase
{
	public uint data_len;

	public RailID remote_peer;

	public uint message_type;

	public string data_buf;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RoomDataReceived()
	{
	}
}
