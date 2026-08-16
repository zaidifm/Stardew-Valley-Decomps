using System;
using Galaxy.Api;

namespace StardewValley.SDKs.GogGalaxy.Listeners;

internal sealed class GalaxyLobbyLeftListener : ILobbyLeftListener
{
	private readonly Action<GalaxyID, LobbyLeaveReason> Callback;

	public GalaxyLobbyLeftListener(Action<GalaxyID, LobbyLeaveReason> callback)
	{
		Callback = callback;
		GalaxyInstance.ListenerRegistrar().Register(GalaxyTypeAwareListenerLobbyLeft.GetListenerType(), this);
	}

	public override void OnLobbyLeft(GalaxyID lobbyID, LobbyLeaveReason leaveReason)
	{
		Callback?.Invoke(lobbyID, leaveReason);
	}

	public override void Dispose()
	{
		GalaxyInstance.ListenerRegistrar().Unregister(GalaxyTypeAwareListenerLobbyLeft.GetListenerType(), this);
		base.Dispose();
	}
}
