using System;
using Galaxy.Api;

namespace StardewValley.SDKs.GogGalaxy.Listeners;

internal sealed class GalaxyLobbyCreatedListener : ILobbyCreatedListener
{
	private readonly Action<GalaxyID, LobbyCreateResult> Callback;

	public GalaxyLobbyCreatedListener(Action<GalaxyID, LobbyCreateResult> callback)
	{
		Callback = callback;
		GalaxyInstance.ListenerRegistrar().Register(GalaxyTypeAwareListenerLobbyCreated.GetListenerType(), this);
	}

	public override void OnLobbyCreated(GalaxyID lobbyID, LobbyCreateResult result)
	{
		Callback?.Invoke(lobbyID, result);
	}

	public override void Dispose()
	{
		GalaxyInstance.ListenerRegistrar().Unregister(GalaxyTypeAwareListenerLobbyCreated.GetListenerType(), this);
		base.Dispose();
	}
}
