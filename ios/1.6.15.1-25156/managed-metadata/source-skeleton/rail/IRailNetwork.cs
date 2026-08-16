using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailNetwork
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AcceptSessionRequest(RailID local_peer, RailID remote_peer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SendData(RailID local_peer, RailID remote_peer, byte[] data_buf, uint data_len, uint message_type);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SendData(RailID local_peer, RailID remote_peer, byte[] data_buf, uint data_len);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SendReliableData(RailID local_peer, RailID remote_peer, byte[] data_buf, uint data_len, uint message_type);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SendReliableData(RailID local_peer, RailID remote_peer, byte[] data_buf, uint data_len);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsDataReady(RailID local_peer, out uint data_len, out uint message_type);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsDataReady(RailID local_peer, out uint data_len);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult ReadData(RailID local_peer, RailID remote_peer, byte[] data_buf, uint data_len, uint message_type);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult ReadData(RailID local_peer, RailID remote_peer, byte[] data_buf, uint data_len);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult BlockMessageType(RailID local_peer, uint message_type);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult UnblockMessageType(RailID local_peer, uint message_type);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult CloseSession(RailID local_peer, RailID remote_peer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult ResolveHostname(string domain, List<string> ip_list);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetSessionState(RailID remote_peer, RailNetworkSessionState session_state);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult ForbidSessionRelay(bool forbid_relay);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SendRawData(RailID local_peer, RailGamePeer remote_game_peer, byte[] data_buf, uint data_len, bool reliable, uint message_type);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AcceptRawSessionRequest(RailID local_peer, RailGamePeer remote_game_peer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult ReadRawData(RailID local_peer, RailGamePeer remote_game_peer, byte[] data_buf, uint data_len, uint message_type);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult ReadRawData(RailID local_peer, RailGamePeer remote_game_peer, byte[] data_buf, uint data_len);
}
