using System;
using Galaxy.Api;

namespace StardewValley.SDKs.GogGalaxy.Listeners;

internal sealed class GalaxyLobbyDataListener : ILobbyDataListener
{
	private readonly Action<GalaxyID, GalaxyID> Callback;

	public GalaxyLobbyDataListener(Action<GalaxyID, GalaxyID> callback)
	{
		Callback = callback;
		GalaxyInstance.ListenerRegistrar().Register(GalaxyTypeAwareListenerLobbyData.GetListenerType(), this);
	}

	public override void OnLobbyDataUpdated(GalaxyID lobbyID, GalaxyID memberID)
	{
		Callback?.Invoke(lobbyID, memberID);
	}

	public override void Dispose()
	{
		GalaxyInstance.ListenerRegistrar().Unregister(GalaxyTypeAwareListenerLobbyData.GetListenerType(), this);
		base.Dispose();
	}
}
