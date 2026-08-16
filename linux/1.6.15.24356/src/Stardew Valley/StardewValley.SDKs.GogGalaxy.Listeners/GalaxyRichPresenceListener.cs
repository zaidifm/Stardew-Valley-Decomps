using System;
using Galaxy.Api;

namespace StardewValley.SDKs.GogGalaxy.Listeners;

internal sealed class GalaxyRichPresenceListener : IRichPresenceListener
{
	private readonly Action<GalaxyID> Callback;

	public GalaxyRichPresenceListener(Action<GalaxyID> callback)
	{
		Callback = callback;
		GalaxyInstance.ListenerRegistrar().Register(GalaxyTypeAwareListenerRichPresence.GetListenerType(), this);
	}

	public override void OnRichPresenceUpdated(GalaxyID userID)
	{
		Callback?.Invoke(userID);
	}

	public override void Dispose()
	{
		GalaxyInstance.ListenerRegistrar().Unregister(GalaxyTypeAwareListenerRichPresence.GetListenerType(), this);
		base.Dispose();
	}
}
