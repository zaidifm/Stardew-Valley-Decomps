using System;
using Galaxy.Api;

namespace StardewValley.SDKs.GogGalaxy.Listeners;

internal sealed class GalaxyGameJoinRequestedListener : IGameJoinRequestedListener
{
	private readonly Action<GalaxyID, string> Callback;

	public GalaxyGameJoinRequestedListener(Action<GalaxyID, string> callback)
	{
		Callback = callback;
		GalaxyInstance.ListenerRegistrar().Register(GalaxyTypeAwareListenerGameJoinRequested.GetListenerType(), this);
	}

	public override void OnGameJoinRequested(GalaxyID lobbyID, string result)
	{
		Callback?.Invoke(lobbyID, result);
	}

	public override void Dispose()
	{
		GalaxyInstance.ListenerRegistrar().Unregister(GalaxyTypeAwareListenerGameJoinRequested.GetListenerType(), this);
		base.Dispose();
	}
}
