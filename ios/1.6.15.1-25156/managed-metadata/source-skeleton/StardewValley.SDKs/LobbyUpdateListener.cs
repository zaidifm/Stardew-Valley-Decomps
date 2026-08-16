using System.Runtime.CompilerServices;

namespace StardewValley.SDKs;

public interface LobbyUpdateListener
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	void OnLobbyUpdate(object lobby);
}
