using System;
using Galaxy.Api;

namespace StardewValley.SDKs.GogGalaxy.Listeners;

internal sealed class GalaxyLobbyEnteredListener : ILobbyEnteredListener
{
	private readonly Action<GalaxyID, LobbyEnterResult> Callback;

	public GalaxyLobbyEnteredListener(Action<GalaxyID, LobbyEnterResult> callback)
	{
		Callback = callback;
		GalaxyInstance.ListenerRegistrar().Register(GalaxyTypeAwareListenerLobbyEntered.GetListenerType(), this);
	}

	public override void OnLobbyEntered(GalaxyID lobbyID, LobbyEnterResult result)
	{
		Callback?.Invoke(lobbyID, result);
	}

	public override void Dispose()
	{
		GalaxyInstance.ListenerRegistrar().Unregister(GalaxyTypeAwareListenerLobbyEntered.GetListenerType(), this);
		base.Dispose();
	}
}
