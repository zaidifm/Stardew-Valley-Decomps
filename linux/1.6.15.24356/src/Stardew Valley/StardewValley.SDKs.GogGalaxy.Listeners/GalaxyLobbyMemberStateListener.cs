using System;
using Galaxy.Api;

namespace StardewValley.SDKs.GogGalaxy.Listeners;

internal sealed class GalaxyLobbyMemberStateListener : ILobbyMemberStateListener
{
	private readonly Action<GalaxyID, GalaxyID, LobbyMemberStateChange> Callback;

	public GalaxyLobbyMemberStateListener(Action<GalaxyID, GalaxyID, LobbyMemberStateChange> callback)
	{
		Callback = callback;
		GalaxyInstance.ListenerRegistrar().Register(GalaxyTypeAwareListenerLobbyMemberState.GetListenerType(), this);
	}

	public override void OnLobbyMemberStateChanged(GalaxyID lobbyID, GalaxyID memberID, LobbyMemberStateChange memberStateChange)
	{
		Callback?.Invoke(lobbyID, memberID, memberStateChange);
	}

	public override void Dispose()
	{
		GalaxyInstance.ListenerRegistrar().Unregister(GalaxyTypeAwareListenerLobbyMemberState.GetListenerType(), this);
		base.Dispose();
	}
}
